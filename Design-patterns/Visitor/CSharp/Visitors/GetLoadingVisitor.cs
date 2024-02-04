using Visitor.Equipments;

namespace Visitor.Visitors
{
    public class GetLoadingVisitor : EquipmentVisitor
    {
        public int Loading { get; private set; }

        public override void VisitEquipment(Equipment equipment)
        {
            Loading += equipment.Loading;
        }

        public override void VisitArmor(Armor armor)
        {
            VisitEquipment(armor);
        }

        public override void VisitWeapon(Weapon weapon)
        {
            VisitEquipment(weapon);
        }
    }
}
