using System.Xml.Linq;

namespace RedoCapstone
{
    public abstract class Entity : ISaveable
    {
        public int id;
        public string name;
        public string description;
        public int weight;
        public string type;
        public int quantity;

        //Method for generating an xml object from the characters info
        public abstract XElement ToXElement();

    }
}
