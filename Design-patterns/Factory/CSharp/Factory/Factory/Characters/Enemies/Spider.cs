using System;

namespace Factory.Characters.Enemies
{
    public class Spider : IEnemy
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set Spider's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set Spider's MP to " + mp);
        }

        public void SetLevel(int level)
        {
            Console.WriteLine("Set Spider's initial level to " + level);
        }
    }
}