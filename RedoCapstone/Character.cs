using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : LivingEntity
    {

        Character(string name, string species, int dex, int con, int wil, int healthPoints, int staminaPoints)
        {
            this.name = name;
            this.species = species;
            this.DexterityScore = dex;
            this.ConstitutionScore = con;
            this.WillpowerScore = wil;

            HealthPoints = healthPoints;
            StaminaPoints = staminaPoints;

        }

    }
}
