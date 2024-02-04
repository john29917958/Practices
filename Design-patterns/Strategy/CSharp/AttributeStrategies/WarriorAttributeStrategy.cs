namespace Strategy.AttributeStrategies
{
    public class WarriorAttributeStrategy : AttributeStrategy
    {
        public override int Health => Properites.Level * Properites.Strength * 5;
        public override int Mana => Properites.Level * Properites.Wisdom;
        public override int Attack => Properites.Level + Properites.Strength * 10;
        public override int MagicalAttack => Properites.Level + Properites.Wisdom;
        public override int Defense => Properites.Level + Properites.Strength * 5;
        public override int MagicalDefense => Properites.Level + Properites.Wisdom;
    }
}
