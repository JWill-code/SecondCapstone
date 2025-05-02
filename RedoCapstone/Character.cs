using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RedoCapstone
{
    internal class Character : LivingEntity, IHasStamina
    {
        public int StaminaPoints { get; set; }

        //Defualt Constructor - mostly a place holder / testing tool
        public Character() { }

        public Character(string name, string species, int dex, int con, int wil, int healthPoints, int staminaPoints)
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

        //Method for generating an xml object from the characters info
        public override XElement ToXElement()
        {
            return new XElement("Character",
                new XElement("Name", name),
                new XElement("Weight", weight),
                new XElement("Species", species),
                new XElement("Stamina", StaminaPoints),
                new XElement("Dexterity", BaseDexterityScore),
                new XElement("Constitution", BaseConstitutionScore),
                new XElement("Willpower", BaseWillpowerScore),
                new XElement("Equipment",
                    Equipment.Select(x => x.ToXElement()
                )
            ));
        }
        /*the goal is to have the name of the character as a primary key and then
        for the combobox where all the names are stored, click one and see all attributes. 
        I just need buttons to go between the pages.*/

    }
}