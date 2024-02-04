namespace Flyweight
{
    public enum Characters { Spider, Ghost, Satan }

    public interface IAttributes
    {
        int Hp { get; }

        int Mp { get; }

        int Speed { get; }
    }
}