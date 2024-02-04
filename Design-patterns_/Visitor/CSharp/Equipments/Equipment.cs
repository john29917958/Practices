using Visitor.Visitors;

namespace Visitor.Equipments
{
    public abstract class Equipment
    {
        public string Name { get; protected set; }
        public int Loading { get; protected set; }

        protected Equipment(string name, int loading)
        {
            Name = name;
            Loading = loading;
        }

        public abstract void RunVisitor(EquipmentVisitor visitor);
    }
}
