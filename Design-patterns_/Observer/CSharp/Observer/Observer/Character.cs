namespace Observer
{
    public enum Races { Human, Elf, Orc, Undead }

    public class Character
    {
        public string Name;
        public Races Race;
        public int X;
        public int Y;
        public int Hp;
        public int Mana;
    }
}