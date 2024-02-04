namespace Strategy.Attributes
{
    public interface IAttributes
    {
        int Health { get; }
        int Mana { get; }
        int Attack { get; }
        int MagicalAttack { get; }
        int Defense { get; }
        int MagicalDefense { get; }
    }
}
