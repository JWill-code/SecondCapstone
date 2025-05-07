using System.Collections.Generic;

namespace RedoCapstone
{
    public interface IHasInventory
    {
        List<Entity> Inventory { get; set; }
        void AddItem(Entity entity);
        void RemoveItem(Entity entity);
    }
}
