using Visitor.Visitors;

namespace Visitor.Equipments
{
    public class Armor : Equipment
    {
        public int Endurance { get; protected set; }

        public Armor(string name, int loading, int endurance) : base(name, loading)
        {
            Endurance = endurance;
        }

        public override void RunVisitor(EquipmentVisitor visitor)
        {
            visitor.VisitArmor(this);
        }

        public void TakeDamage()
        {
            Endurance -= 1;
            if (Endurance < 0) Endurance = 0;
        }
    }
}
