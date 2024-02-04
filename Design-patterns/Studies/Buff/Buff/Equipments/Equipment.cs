namespace BuffPattern.Equipments
{
    public abstract class Equipment : IUpdateable
    {
        public string Name { get; protected set; }
        public int Level { get; set; }
        public int Loading { get; protected set; }
        public int Endurance { get; protected set; }

        private Character _character;

        protected Equipment(string name, int level, int loading, int endurance)
        {
            Name = name;
            Level = level;
            Loading = loading;
            Endurance = endurance;
        }

        public virtual void AttachTo(Character character)
        {
            _character = character;
            character.Equipments.Add(this);
        }

        public virtual void Detach()
        {
            _character?.Equipments.Remove(this);
        }

        public virtual void Update()
        {
            
        }
    }
}
