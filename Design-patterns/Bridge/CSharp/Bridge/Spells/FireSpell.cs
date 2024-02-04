using System;

namespace Bridge.Spells
{
    public class FireSpell : Spell
    {
        public FireSpell(int power, int speed, int cost) : base(power, speed, cost)
        {

        }

        public override void Cast()
        {
            Console.WriteLine($"Casts a fire spell with power {Power} and speed {Speed}. Applies burning effect.");
        }
    }
}
