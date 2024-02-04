using System;

namespace Bridge.Spells
{
    public class IceSpell : Spell
    {
        public IceSpell(int power, int speed, int cost) : base(power, speed, cost)
        {

        }

        public override void Cast()
        {
            Console.WriteLine($"Casts a ice spell with power {Power} and speed {Speed}. Freezes the enemy 3 seconds.");
        }
    }
}
