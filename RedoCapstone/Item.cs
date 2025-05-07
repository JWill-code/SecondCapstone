using System.Xml.Linq;

namespace RedoCapstone
{
    public class Item : Entity
    {

        public Item(int id, string name, int quantity, string description, int weight)
        {
            this.id = id;
            this.name = name;
            this.type = "item";
            this.quantity = quantity;
            this.description = description;
            this.weight = weight;
        }

        public Item() { }

        public override XElement ToXElement()
        {
            return new XElement("Item",
                new XAttribute("id", id),
                new XElement("Name", name),
                new XElement("Quantity", quantity),
                new XElement("Description", description),
                new XElement("Weight", weight)
            );
        }
    }
}
