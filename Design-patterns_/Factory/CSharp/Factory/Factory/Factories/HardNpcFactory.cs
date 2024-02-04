using System;
using Factory.Characters.Enemies;
using Factory.Characters.Soldiers;

namespace Factory.Factories
{
    public class HardNpcFactory : INpcFactory
    {
        public ISoldier Make(Soldiers soldierType)
        {
            INpcFactory defaultFactory = new DefaultNpcFactory();
            return defaultFactory.Make(soldierType);
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

            // Ultra difficult version of enemy...
            enemy.SetHp(1000);
            enemy.SetMp(1000);
            enemy.SetLevel(100);

            return enemy;
        }
    }
}