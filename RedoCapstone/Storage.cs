using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RedoCapstone
{
    internal class Storage : Entity, IHasInventory
    {
        public List<Entity> Inventory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddItem(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(Entity entity)
        {
            throw new NotImplementedException();
        }

        public override XElement ToXElement()
        {
            throw new NotImplementedException();
        }
    }
}
