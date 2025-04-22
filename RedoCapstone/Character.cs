using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : IHasHP
    {

        string name;
        string race;
        int dex;
        int con;
        int wil;
        public int Hitpoints { get; set; }

        Character(string name, string race, int dex, int con, int wil)
        {
            this.name = name;
            this.race = race;
            this.dex = dex;
            this.con = con;
            this.wil = wil;
        }

    }
}
