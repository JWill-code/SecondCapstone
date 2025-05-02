using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Character : LivingEntity, IHasStamina
    {
        public int StaminaPoints { get; set; }
        Character(string name, string species, int dex, int con, int wil, int healthPoints, int staminaPoints)
        {
            this.name = name; //primary key
            //CharListBox.Text;
            this.species = species;
            this.BaseDexterityScore = dex;
            this.BaseConstitutionScore = con;
            this.BaseWillpowerScore = wil;
            //these are all LivingEntity

            HealthPoints = healthPoints;
            StaminaPoints = staminaPoints;
            

        }
        /*the goal is to have the name of the character as a primary key and then
         for the combobox where all the names are stored, click one and see all attributes. 
        I just need buttons to go between the pages.*/
        

    }
}
