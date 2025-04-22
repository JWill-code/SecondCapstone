using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    internal class LivingEntity: Entity , IHasAttributes, IHasEquipment
    {
        protected string species;

        public int DexterityScore { set; get; }
        public int ConstitutionScore { set; get; }
        public int WillpowerScore { set; get; }

    }
}
