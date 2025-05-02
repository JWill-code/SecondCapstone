using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : LivingEntity, IHasStamina, IHasAttributes
    {
        public int StaminaPoints { get; set; }
        Character(string name, string species, int dex, int con, int wil, int healthPoints, int staminaPoints)
        {
            this.name = name;
            this.species = species;
            this.BaseDexterityScore = dex;
            this.BaseConstitutionScore = con;
            this.BaseWillpowerScore = wil;

            //these are all LivingEntity

            HealthPoints = healthPoints;
            StaminaPoints = staminaPoints;

        }

    }
}
