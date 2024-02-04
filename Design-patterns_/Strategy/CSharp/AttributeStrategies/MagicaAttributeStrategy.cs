namespace Strategy.AttributeStrategies
{
    public class MagicaAttributeStrategy : AttributeStrategy
    {
        public override int Health => Properites.Level * Properites.Strength;
        public override int Mana => Properites.Level * Properites.Wisdom * 5;
        public override int Attack => Properites.Level + Properites.Strength;
        public override int MagicalAttack => Properites.Level + Properites.Wisdom * 10;
        public override int Defense => Properites.Level + Properites.Strength;
        public override int MagicalDefense => Properites.Level + Properites.Wisdom * 5;
    }
}
