using System;
using Visitor.Equipments;

namespace Visitor.Visitors
{
    public class RemoveBrokenArmorVisitor : EquipmentVisitor
    {
        private readonly Backpack _backpack;

        public RemoveBrokenArmorVisitor(Backpack backpack)
        {
            _backpack = backpack;
        }

        public override void VisitArmor(Armor armor)
        {
            if (armor.Endurance == 0)
            {
                _backpack.Remove(armor);
                Console.WriteLine($"Armor \"{armor.Name}\" is broken, remove it.");
            }
        }
    }
}
