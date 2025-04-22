using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal interface IHasEquipment
    {
        List<IEquipable> Equipment { get; set; }
        void DonItem(Entity entity);
        void DofItem(Entity entity);
    }
}

