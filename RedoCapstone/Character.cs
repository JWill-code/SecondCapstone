using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : IHasHealth, IHasStamina
    {

        string name;
        string race;
        int dex;
        int con;
        int wil;
        public int HealthPoints { get; set; }
        public int StaminaPoints { get; set; }

        Character(string name, string race, int dex, int con, int wil, int healthPoints, int staminaPoints)
        {
            this.name = name;
            this.race = race;
            this.dex = dex;
            this.con = con;
            this.wil = wil;

            HealthPoints = healthPoints;
            StaminaPoints = staminaPoints;

        }

    }
}
