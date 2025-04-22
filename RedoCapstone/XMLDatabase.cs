using System;
using System.Xml.Linq;

class XMLDatabase{

    static void main{
        // This will grab the user's information and store it in a database that will eventually be updateable and retreiveable

        int statPoints = 27;

        Console.Write("Enter your Character Name: ");
        string charName = Console.ReadLine();
        Console.Write("Enter Class: ");
        string class = Console.ReadLine();
        Console.Write("Enter level: ");
        int level = int(Console.ReadLine());
        Console.Write("Enter Race: ");
        string class = Console.ReadLine();

        // this is just going to be a basic stat point distribution. Can make it more advanced later
        while(statPoints > 0){
            Console.Write("Allocate stat points (27 stat points available)");
            Console.Write("Strength (base = 8): ");
            int str = int(Console.ReadLine());
            Console.Write("Dexterity (base = 8): ");
            int dex = int(Console.ReadLine());
            Console.Write("Constitution (base = 8): ");
            int cons = int(Console.ReadLine());
            Console.Write("Intelligence (base = 8): ");
            int intel = int(Console.ReadLine());
            Console.Write("Wisdom (base = 8): ");
            int wis = int(Console.ReadLine());
            Console.Write("Charisma (base = 8): ");
            int charisma = int(Console.ReadLine());
            
        }
        XElement charactersXML = new XElement("Characters",
            new XElement("Character",
                new Xelement("Character Name", )))
    }
}