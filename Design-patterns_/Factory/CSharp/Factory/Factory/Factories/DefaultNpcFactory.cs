using System;
using Factory.Characters.Enemies;
using Factory.Characters.Soldiers;

namespace Factory.Factories
{
    public class DefaultNpcFactory : INpcFactory
    {
        public ISoldier Make(Soldiers soldierType)
        {
            ISoldier soldier;

            switch (soldierType)
            {
                case Soldiers.Knight:
                    soldier = new Knight();
                    break;
                case Soldiers.Cavalry:
                    soldier = new Cavalry();
                    break;
                case Soldiers.DragonKnight:
                    soldier = new DragonKnight();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Soldier type " + soldierType + " is not supported.");
            }

            soldier.SetHp(100);
            soldier.SetMp(100);

            return soldier;
        }

        public IEnemy Make(Enemies enemyType)
        {
            IEnemy enemy;

            switch (enemyType)
            {
                case Enemies.Spider:
                    enemy = new Spider();
                    break;
                case Enemies.Ghost:
                    enemy = new Ghost();
                    break;
                case Enemies.Satan:
                    enemy = new Satan();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Enemy type " + enemyType + " is not supported");
            }

            enemy.SetHp(100);
            enemy.SetMp(100);
            enemy.SetLevel(1);

            return enemy;
        }
    }
}