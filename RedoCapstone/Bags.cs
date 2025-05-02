using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class Bags : Item, IEquipable, IHasInventory
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
    }
}
