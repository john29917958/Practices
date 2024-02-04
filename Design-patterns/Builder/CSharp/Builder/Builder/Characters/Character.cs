namespace Builder.Characters
{
    public enum Characters { Player, Enemy }

    public enum Weapons { Gun, Sword }

    public class Character
    {
        public int X;
        public int Y;
        public string Name;
        public int Health;
        public int Mana;
        public int MoveSpeed;
        public Weapon Weapon;
        public Ai Ai;
    }

    public class Weapon
    {

    }

    public class Ai
    {

    }
}