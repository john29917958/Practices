namespace Strategy.Attributes
{
    public class Attributes : IAttributes
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Attack { get; set; }
        public int MagicalAttack { get; set; }
        public int Defense { get; set; }
        public int MagicalDefense { get; set; }

        public Attributes()
        {

        }

        public Attributes(IAttributes initAttributes)
        {
            Health = initAttributes.Health;
            Mana = initAttributes.Mana;
            Attack = initAttributes.Attack;
            MagicalAttack = initAttributes.MagicalAttack;
            Defense = initAttributes.Defense;
            MagicalDefense = initAttributes.MagicalDefense;
        }
    }
}
