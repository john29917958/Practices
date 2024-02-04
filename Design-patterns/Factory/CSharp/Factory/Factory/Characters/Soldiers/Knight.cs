using System;

namespace Factory.Characters.Soldiers
{
    public class Knight : ISoldier
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set Knight's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set Knight's MP to " + mp);
        }
    }
}