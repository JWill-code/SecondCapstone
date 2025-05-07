using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace RedoCapstone
{
    public class LivingEntity : Entity, IHasAttributes, IHasEquipment, IHasHealth, IHasInventory
    {
        public string species { get; set; }

        public int HealthPoints { get; set; }

        public List<Entity> Equipment = new List<Entity>();

        public void DonItem(Entity entity) { this.Equipment.Add(entity); }
        public void DofItem(Entity entity) { this.Equipment.Remove(entity); }

        public int BaseDexterityScore { set; get; }
        public int BaseConstitutionScore { set; get; }
        public int BaseWillpowerScore { set; get; }
        public List<Entity> Inventory { get; set; }

        public int GetDexterityScore() { return this.BaseDexterityScore; }
        public int GetConstitutionScore() { return this.BaseConstitutionScore; }
        public int GetWillpowerScore() { return this.BaseWillpowerScore; }

        public override XElement ToXElement()
        {
            throw new NotImplementedException();
        }

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
