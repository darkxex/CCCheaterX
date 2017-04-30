using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCAPI_Cheat
{
    public class CheatLine
    {
        public string Opcode { get; set; }

        public string Param1 { get; set; }

        public string Param2 { get; set; }

        public CheatLine(string opc, string pa1, string pa2)
        {
            this.Opcode = opc;
            this.Param1 = pa1;
            this.Param2 = pa2;
        }

        public string Apply(string lastReturn)
        {
            switch (this.Opcode)
            {
                case "00002000":
                    return this.Handle_00002000_Opcode(lastReturn);
                default:
                    int num = (int)MessageBox.Show("The cheat contains unimplemented opcodes and can't be applied");
                    return "00000000";
            }
        }

        public bool ContainsUnimplementedOpcodes()
        {
            return !(this.Opcode == "00002000");
        }

        private string Handle_00002000_Opcode(string lastReturn)
        {
            try
            {
                uint uint32_1 = Convert.ToUInt32(this.Param1, 16);
                uint uint32_2 = Convert.ToUInt32(this.Param2, 16);
               

                if ((int)uint32_1 == 0)
                    uint32_1 = Convert.ToUInt32(lastReturn, 16);
                Form1.ccapi.WriteMemoryI32(uint32_1, (int)uint32_2);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, "Error handling 00002000 Opcode", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return "00000000";
        }

        public override string ToString()
        {
            return this.Opcode + (object)' ' + this.Param1 + (object)' ' + this.Param2;
        }
    }
}
