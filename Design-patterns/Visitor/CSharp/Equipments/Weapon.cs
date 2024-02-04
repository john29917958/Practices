using System;
using Visitor.Visitors;

namespace Visitor.Equipments
{
    public class Weapon : Equipment
    {
        public Weapon(string name, int loading) : base(name, loading)
        {

        }

        public override void RunVisitor(EquipmentVisitor visitor)
        {
            visitor.VisitWeapon(this);
        }

        public void Attack()
        {
            Console.WriteLine($"Weapon {Name} attacks.");
        }
    }
}
