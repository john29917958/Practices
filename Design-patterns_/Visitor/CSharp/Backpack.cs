using System;
using System.Collections.Generic;
using Visitor.Equipments;
using Visitor.Visitors;

namespace Visitor
{
    public class Backpack
    {
        public int Loading
        {
            get
            {
                GetLoadingVisitor visitor = new GetLoadingVisitor();
                RunVisitor(visitor);
                return visitor.Loading;
            }
        }

        public int MaxLoading;

        public Equipment[] Equipments => _equipments.ToArray();

        private readonly List<Equipment> _equipments;

        public Backpack(int maxLoading)
        {
            MaxLoading = maxLoading;
            _equipments = new List<Equipment>();
        }

        public void Add(Equipment equipment)
        {
            if (equipment.Loading + Loading > MaxLoading)
            {
                Console.WriteLine($"Failed to add equipment {equipment.Name} (Run out of max loading).");
                return;
            }

            _equipments.Add(equipment);
        }

        public void Remove(Equipment equipment)
        {
            _equipments.Remove(equipment);
        }

        public void RunVisitor(EquipmentVisitor visitor)
        {
            foreach (Equipment equipment in Equipments)
            {
                equipment.RunVisitor(visitor);
            }
        }
    }
}