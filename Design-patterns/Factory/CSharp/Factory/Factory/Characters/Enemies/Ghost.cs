using System;

namespace Factory.Characters.Enemies
{
    public class Ghost : IEnemy
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set Ghost's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set Ghost's MP to " + mp);
        }

        public void SetLevel(int level)
        {
            Console.WriteLine("Set Ghost's MP to " + level);
        }
    }
}