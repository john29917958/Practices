namespace Flyweight
{
    public class CharacterAttributes : IAttributes
    {
        public int Level;

        public int Hp
        {
            get => _hp;
            set => _hp = value > _baseAttributes.Hp ? _baseAttributes.Hp : value;
        }

        public int Mp
        {
            get => _mp;
            set => _mp = value > _baseAttributes.Mp ? _baseAttributes.Mp : value;
        }
        public int Speed => _baseAttributes.Speed;

        private readonly IAttributes _baseAttributes;

        private int _hp;

        private int _mp;

        public CharacterAttributes(IAttributes baseAttributes)
        {
            _baseAttributes = baseAttributes;
            
            Level = 0;
        }

        public void FillHpAndMp()
        {
            Hp = _baseAttributes.Hp;
            Mp = _baseAttributes.Mp;
        }
    }
}