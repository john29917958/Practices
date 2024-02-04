namespace Memento
{
    public class Character : ISerializable<CharacterMemento>
    {
        public string Name { get; private set; }

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Health { get; private set; }

        private string _state;

        public Character(string name)
        {
            Name = name;
            X = 0;
            Y = 0;
            Health = 100;
            _state = "Idle";
        }

        public CharacterMemento Export()
        {
            CharacterMemento memento = new CharacterMemento
            {
                Name = Name,
                X = X,
                Y = Y,
                Health = Health,
                State = _state
            };

            return memento;
        }

        public void Import(CharacterMemento memento)
        {
            Name = memento.Name;
            X = memento.X;
            Y = memento.Y;
            Health = memento.Health;
            _state = memento.State;
        }

        public void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void TakeDamage(int value)
        {
            Health -= value;
            if (Health < 0) Health = 0;
        }

        public void Cure(int value)
        {
            Health += value;
            if (Health > 100) Health = 100;
        }

        public override string ToString()
        {
            string message = $@"Name: {Name}
X: {X}
Y: {Y}
Health: {Health}
State: {_state}";

            return message;
        }
    }
}