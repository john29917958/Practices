namespace Command
{
    public class Character : ICharacterAttributes
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
    }
}