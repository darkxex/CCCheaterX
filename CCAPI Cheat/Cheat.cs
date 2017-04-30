using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPI_Cheat
{
    public class Cheat
    {
        public List<CheatLine> cheatLines = new List<CheatLine>();

        public string Name { get; set; }

        public Cheat(string name)
        {
            this.Name = name;
        }

        public void Apply()
        {
            if (!this.ContainsUnimplementedOpcodes())
            {
                string lastReturn = "00000000";
                foreach (CheatLine cheatLine in this.cheatLines)
                    lastReturn = cheatLine.Apply(lastReturn);
               
                Form1.ccapi.VshNotify(CCAPI.NotifyIcon.Trophy4, "Cheat applied!");
                Form1.ccapi.RingBuzzer(CCAPI.BuzzerType.Single);
                int num = (int)MessageBox.Show("Cheat applied!");
            }
            else
            {
                int num1 = (int)MessageBox.Show("The cheat contains unimplemented opcodes and can't be applied");
            }
        }

        private bool ContainsUnimplementedOpcodes()
        {
            foreach (CheatLine cheatLine in this.cheatLines)
            {
                if (cheatLine.ContainsUnimplementedOpcodes())
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
