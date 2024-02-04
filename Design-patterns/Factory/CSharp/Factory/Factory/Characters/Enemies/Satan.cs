using System;

namespace Factory.Characters.Enemies
{
    public class Satan : IEnemy
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set Satan's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set Satan's MP to " + mp);
        }

        public void SetLevel(int level)
        {
            Console.WriteLine("Set Satan's MP to " + level);
        }
    }
}