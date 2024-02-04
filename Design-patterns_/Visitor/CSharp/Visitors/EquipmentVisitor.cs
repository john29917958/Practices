using Visitor.Equipments;

namespace Visitor.Visitors
{
    public abstract class EquipmentVisitor
    {
        public virtual void VisitEquipment(Equipment equipment)
        {

        }

        public virtual void VisitWeapon(Weapon weapon)
        {

        }

        public virtual void VisitArmor(Armor armor)
        {

        }
    }
}
