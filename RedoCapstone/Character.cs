using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : Entity
    {

        string name;
        string race;
        int dex;
        int con;
        int wil;

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
