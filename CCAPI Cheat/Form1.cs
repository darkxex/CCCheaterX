using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPI_Cheat
{
   
    public partial class Form1 : Form
    {
        private bool currentGame;
        public List<Game> gameList = new List<Game>();
        public static CCAPI ccapi = new CCAPI();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            label3.Text = ("CCAPI Version: ");
            label4.Text = ("CCAPI Library version: ");
            label2.Text = ("Firmware: ");
            label5.Text = "Console Type: " ;
            label6.Text = "CELL Temp: " ;
            label7.Text = "RSX Temp: ";
            this.EnableBoxes(false);
            this.LoadCheatFile();
            foreach (object game in this.gameList)
                this.comboGames.Items.Add(game);
        }
        private void AddGame(Game game)
        {
            this.gameList.Add(game);
        }
        private void LoadCheatFile()
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            Game game = (Game)null;
            Cheat cheat = (Cheat)null;
            foreach (string readLine in File.ReadLines("CheatsDB.ps3cheat"))
            {
                if (readLine.Contains("------") && !flag1)
                    flag1 = true;
                else if (!readLine.Contains("------") && flag1)
                {
                    game = new Game(readLine);
                    this.AddGame(game);
                }
                else if (readLine.Contains("------") && flag1)
                {
                    flag1 = false;
                    flag2 = true;
                }
                else if (flag2 || readLine.Contains<char>('<') && readLine.Contains<char>('>'))
                {
                    cheat = new Cheat(readLine);
                    game.cheats.Add(cheat);
                    flag2 = false;
                    flag3 = true;
                }
                else
                {
                    if (flag3 && readLine.Length > 2)
                    {
                        string[] strArray = readLine.Split(' ');
                        cheat.cheatLines.Add(new CheatLine(strArray[0], strArray[1], strArray[2]));
                    }
                    if (flag3 && readLine.Length < 2)
                        flag3 = false;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!ccapi.GetLibraryState())
            {
                Console.WriteLine("CCAPI Library couldn't be loaded.");
                Console.WriteLine("Check that you are using the correct CCAPI.dll.");
            }
            else
            {
                List<CCAPI.ConsoleInfo> cInfo = ccapi.GetConsoleList();

                for (int c = 0; c < cInfo.Count; ++c)
                {
                    Console.WriteLine("Console:{0} Ip:{1}", cInfo[c].name, cInfo[c].ip);
                }

                if (ccapi.Connect("192.168.1.91") != CCAPI.OK) //_PS3_IP_HERE_
                {
                    Console.WriteLine("Couldn't establish a connection with your PS3.");
                    Console.WriteLine("Verify your ps3 ip.");
                }
                else
                {
                    Console.WriteLine("Connected to your PS3.");
                    ccapi.VshNotify(CCAPI.NotifyIcon.Trophy2, "Connected to CCAPI");
                    ccapi.RingBuzzer(CCAPI.BuzzerType.Triple);

                    int firmware = 0, version = 0;
                    CCAPI.ConsoleType cType = CCAPI.ConsoleType.UNK;
                    int cell = 0, rsx = 0;
                    int ret = ccapi.GetFirmwareInfo(ref firmware, ref version, ref cType) |
                              ccapi.GetTemperature(ref cell, ref rsx);

                    if (ret != CCAPI.OK)
                    {
                        Console.WriteLine("An error occured while retrieving console details.");
                    }
                    else
                    {
                        Console.WriteLine("CCAPI Version: {0}", version);
                        Console.WriteLine("CCAPI Library version: {0}", ccapi.GetDllVersion());
                        Console.WriteLine("Firmware: {0}", CCAPI.FirmwareToString(firmware));
                        Console.WriteLine("Console Type: {0}", CCAPI.ConsoleTypeToString(cType));
                        Console.WriteLine("CELL Temp: {0}", cell);
                        Console.WriteLine("RSX Temp: {0}", rsx);


                        if (!ccapi.AttachGameProcess())
                        {
                            Console.WriteLine("Couldn't find a game process.");
                        }
                        else
                        {
                            Console.WriteLine("Process {0:X} attached with success.", ccapi.GetAttachedProcess());

                            byte i = ccapi.ReadMemoryU8(0x50000);
                            Console.WriteLine("Read at 0x50000: {0:X}", i);


                            //  ccapi.SetConsoleIds(CCAPI.ConsoleIdType.Idps,"0123456789ABCDEF0123456789ABCDEF");
                            //  ccapi.WriteMemoryString(0x,"Hello");
                            //  Console.WriteLine("{0}",ccapi.ReadMemoryString(0x));
                            //  ccapi.WriteMemoryI32(0x, 1000);


                        }
                    }
                }
            }
            ccapi.Disconnect();
        }

        private void gbCheats_Enter(object sender, EventArgs e)
        {

        }

        private void groupConnect_Enter(object sender, EventArgs e)
        {

        }

        private void butApplyCheat_Click(object sender, EventArgs e)
        {
            if (this.comboGames.SelectedIndex < 0 || this.comboCheats.SelectedIndex < 0)
                return;
            ((Cheat)this.comboCheats.Items[this.comboCheats.SelectedIndex]).Apply();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            if ((ccapi.Connect(this.BoxIP.Text) == CCAPI.OK))
            {
                ccapi.VshNotify(CCAPI.NotifyIcon.Trophy2, "Connected CCCheaterX by Xex (Thanks Barthen)");
                ccapi.RingBuzzer(CCAPI.BuzzerType.Triple);
                this.EnableBoxes(true);
                int firmware = 0, version = 0;
                CCAPI.ConsoleType cType = CCAPI.ConsoleType.UNK;
                int cell = 0, rsx = 0;
                int ret = ccapi.GetFirmwareInfo(ref firmware, ref version, ref cType) |
                          ccapi.GetTemperature(ref cell, ref rsx);

                if (ret != CCAPI.OK)
                {
                    Console.WriteLine("An error occured while retrieving console details.");
                }
                else
                {
                    label3.Text = ("CCAPI Version: "+ version);
                    label4.Text = ("CCAPI Library version: "+  ccapi.GetDllVersion());
                    label2.Text = ("Firmware: " + CCAPI.FirmwareToString(firmware));
                    label5.Text = ("Console Type: "+CCAPI.ConsoleTypeToString(cType));
                    label6.Text = ("CELL Temp: "+cell);
                    label7.Text = ("RSX Temp: " + rsx);
                }

                if (Form1.ccapi.AttachGameProcess())
                {
                    this.currentGame = true;
                    int num = (int)MessageBox.Show("Successfully connected to game!");
                }
                else
                {
                    int num1 = (int)MessageBox.Show("Are you in a game?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                this.EnableBoxes(false);
                int num = (int)MessageBox.Show("Can't connect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void comboGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Game selectedItem = (Game)this.comboGames.SelectedItem;
            this.comboCheats.Items.Clear();
            this.comboCheats.Text = "";
            foreach (object cheat in selectedItem.cheats)
                this.comboCheats.Items.Add(cheat);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.ccapi.Disconnect();
        }
        private void EnableBoxes(bool active)
        {
            this.gbCheats.Enabled = active;
        }

      
    }
}
