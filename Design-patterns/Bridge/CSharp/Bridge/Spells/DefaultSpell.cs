using System;

namespace Bridge.Spells
{
    public class DefaultSpell : Spell
    {
        public DefaultSpell(int power, int speed, int cost) : base(power, speed, cost)
        {
        }

        public override void Cast()
        {
            Console.WriteLine($"Casts a default air spell with power {Power} and speed {Speed}.");
        }
    }
}
