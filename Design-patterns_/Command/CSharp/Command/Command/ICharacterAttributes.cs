namespace Command
{
    public interface ICharacterAttributes
    {
        string Name { get; }
        int Row { get; }
        int Column { get; }
        int Health { get; }
        int Mana { get; }
    }
}