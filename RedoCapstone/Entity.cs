using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedoCapstone
{
    public class Entity : IHasHealth, IHasStamina
    {
        protected string name;
        protected int weight = 0;
        public int HealthPoints { get; set; }
        public int StaminaPoints { get; set; }
    }
}
