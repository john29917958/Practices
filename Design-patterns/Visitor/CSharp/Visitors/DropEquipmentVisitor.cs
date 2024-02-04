using System;
using Visitor.Equipments;

namespace Visitor.Visitors
{
    public class DropEquipmentVisitor : EquipmentVisitor
    {
        private readonly Equipment _equipment;
        private readonly Backpack _backpack;

        public DropEquipmentVisitor(Equipment equipment, Backpack backpack)
        {
            _equipment = equipment;
            _backpack = backpack;
        }

        public override void VisitEquipment(Equipment equipment)
        {
            if (equipment == _equipment)
            {
                Console.WriteLine($"Drops equipment \"{equipment.Name}\".");
                _backpack.Remove(equipment);
                GameSystem.Instantiate(equipment);
            }
        }

        public override void VisitArmor(Armor armor)
        {
            if (armor == _equipment)
            {
                Console.WriteLine($"Drops equipment \"{armor.Name}\". Creates slash effect.");
                _backpack.Remove(armor);
                GameSystem.Instantiate(armor);
            }
        }

        public override void VisitWeapon(Weapon weapon)
        {
            if (weapon == _equipment)
            {
                Console.WriteLine($"Drops equipment \"{weapon.Name}\". Creates flash effect.");
                _backpack.Remove(weapon);
                GameSystem.Instantiate(weapon);
            }
        }
    }
}
