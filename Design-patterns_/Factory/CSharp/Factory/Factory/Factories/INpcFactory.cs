using Factory.Characters.Enemies;
using Factory.Characters.Soldiers;

namespace Factory.Factories
{
    public interface INpcFactory
    {
        ISoldier Make(Soldiers soldierType);
        IEnemy Make(Enemies enemyType);
    }
}