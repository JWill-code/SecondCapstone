using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    public interface IHasInventory
    {
        List<Entity> Inventory { get; set; }
        void AddItem(Entity entity);
        void RemoveItem(Entity entity);
    }
}
