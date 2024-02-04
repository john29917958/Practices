using System;
using Visitor.Equipments;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Backpack backpack = new Backpack(10);
            Equipment weapon = new Weapon("Knife", 3);
            backpack.Add(weapon);
            backpack.Add(new Armor("Body armor", 3, 3));
            backpack.Add(new Armor("Feet armor", 3, 0));
            backpack.Add(new Armor("Shield", 3, 100));

            EquipmentVisitor visitor = new RemoveBrokenArmorVisitor(backpack);
            backpack.RunVisitor(visitor);

            visitor = new DropEquipmentVisitor(weapon, backpack);
            backpack.RunVisitor(visitor);

            Console.ReadLine();
        }
    }
}
