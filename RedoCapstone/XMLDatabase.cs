using System;
using System.Xml.Linq;

class XMLDatabase{

    public static void RunXml(){
        // This will grab the user's information and store it in a database that will eventually be updateable and retreiveable

        int statPoints = 27;

        Console.Write("Enter your Character Name: ");
        string charName = Console.ReadLine();
        Console.Write("Enter Class: ");
        string cls = Console.ReadLine();
        Console.Write("Enter level: ");
        int level = int(Console.ReadLine());
        Console.Write("Enter Race: ");
        string race = Console.ReadLine();

        // this is just going to be a basic stat point distribution. Can make it more advanced later
            Console.Write("Strength (base = 8): ");
            int str = int.Parse(Console.ReadLine());
            Console.Write("Dexterity (base = 8): ");
            int dex = int.Parse(Console.ReadLine());
            Console.Write("Constitution (base = 8): ");
            int cons = int.Parse(Console.ReadLine());
            Console.Write("Intelligence (base = 8): ");
            int intel = int.Parse(Console.ReadLine());
            Console.Write("Wisdom (base = 8): ");
            int wis = int.Parse(Console.ReadLine());
            Console.Write("Charisma (base = 8): ");
            int crisma = int.Parse(Console.ReadLine());

        XElement charactersXML = new XElement("Characters",
            new XElement("Character",
                new XElement("CharacterName", charName),
                new XElement("Class", cls),
                new XElement("Level", level),
                new XElement("Race", race),
                new XElement("Strength", str),
                new XElement("Dexterity", dex),
                new XElement("Constitution", cons),
                new XElement("Intelligence", intel),
                new XElement("Wisdom", wis),
                new XElement("Charisma", crisma)
            )
        );
        // Save to Database
        charactersXML.Save("characters.xml");
        Console.WriteLine("XML database saved as characters.xml");

        // Reading XML Database
        XDocument doc = XDocument.Load("characters.xml");

        // storing and displaying data from database
        foreach(XElement user in doc.Root.Elements("Character")){
            string name = user.Element("CharacterName").Value;
            string charClass = user.Element("Class").Value;
            string lvl = user.Element("Level").Value;
            string rce = user.Element("Race").Value;
            int strength = user.Element("Strength").Value;
            int dexterity = user.Element("Dexterity").Value;
            int constitution = user.Element("Constitution").Value;
            int intelligence = user.Element("Intelligence").Value;
            int charisma = user.Element("Charisma").Value;

            //display the character data
            Console.WriteLine($"Character name: {name}");
            Console.WriteLine($"Class: {charClass}");
            Console.WriteLine($"Level: {lvl}");
            Console.WriteLine($"Race: {rce}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Dexterity: {dexterity}");
            Console.WriteLine($"Constitution: {constitution}");
            Console.WriteLine($"Intelligence: {intelligence}");
            Console.WriteLine($"Charisma: {charisma}");
        }
    }
}