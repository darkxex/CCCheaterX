using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAPI_Cheat
{
    public class Game
    {
        public List<Cheat> cheats = new List<Cheat>();

        public string Name { get; set; }

        public Game(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
