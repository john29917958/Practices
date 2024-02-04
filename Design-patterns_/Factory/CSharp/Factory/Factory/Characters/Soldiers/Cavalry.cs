using System;

namespace Factory.Characters.Soldiers
{
    public class Cavalry : ISoldier
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set Cavalry's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set Cavalry's MP to " + mp);
        }
    }
}