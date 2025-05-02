using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace RedoCapstone
{
    internal class LivingEntity: Entity , IHasAttributes, IHasEquipment, IHasHealth
    {
        protected string species;

        public int HealthPoints { get; set; }
        public List<Entity> Equipment { get; set; }

        public void DonItem(Entity entity) { }
        public void DofItem(Entity entity) { }

        public int BaseDexterityScore { set; get; }
        public int BaseConstitutionScore { set; get; }
        public int BaseWillpowerScore { set; get; }

        public int GetDexterityScore() { return this.BaseDexterityScore; }
        public int GetConstitutionScore() { return this.BaseConstitutionScore; }
        public int GetWillpowerScore() { return this.BaseWillpowerScore; }

        public override XElement ToXElement()
        {
            throw new NotImplementedException();
        }
    }
}
