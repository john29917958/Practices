using System;

namespace Bridge.Spells
{
    public class CurseSpell : Spell
    {
        public CurseSpell(int power, int speed, int cost) : base(power, speed, cost)
        {

        }

        public override void Cast()
        {
            Console.WriteLine($"Casts a curse spell with power {Power} and speed {Speed}. Shows dark flame effect and keeps damage health of enemy for 10 seconds. Applies curse effect to every enemies who collide with the target enemy.");
        }
    }
}
