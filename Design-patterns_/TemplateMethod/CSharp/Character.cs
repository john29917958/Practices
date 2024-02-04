namespace TemplateMethod
{
    public class Character
    {
        public Vector Position { get; set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }

        public Character()
        {
            Position = new Vector(0, 0, 0);
            Health = 100;
            Mana = 100;
        }
    }
}
