using System;
using Factory.Characters.Enemies;
using Factory.Characters.Soldiers;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISoldier soldier = GameSystem.NpcFactory.Make(Soldiers.Knight);
            soldier = GameSystem.NpcFactory.Make(Soldiers.Cavalry);
            soldier = GameSystem.NpcFactory.Make(Soldiers.DragonKnight);

            IEnemy enemy = GameSystem.NpcFactory.Make(Enemies.Spider);
            enemy = GameSystem.NpcFactory.Make(Enemies.Ghost);
            enemy = GameSystem.NpcFactory.Make(Enemies.Satan);

            GameSystem.IsHardMode = true;
            enemy = GameSystem.NpcFactory.Make(Enemies.Spider);
            enemy = GameSystem.NpcFactory.Make(Enemies.Ghost);
            enemy = GameSystem.NpcFactory.Make(Enemies.Satan);

            Console.ReadLine();
        }
    }
}
