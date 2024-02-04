using System;

namespace Factory.Characters.Soldiers
{
    public class DragonKnight : ISoldier
    {
        public void SetHp(int hp)
        {
            Console.WriteLine("Set DragonKnight's HP to " + hp);
        }

        public void SetMp(int mp)
        {
            Console.WriteLine("Set DragonKnight's MP to " + mp);
        }
    }
}