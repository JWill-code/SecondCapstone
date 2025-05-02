using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RedoCapstone
{
    internal class Item : Entity
    {
        public override XElement ToXElement()
        {
            return new XElement("Item",
                new XElement("Name", name),
                new XElement("Weight", weight)
            );
        }
    }
}
