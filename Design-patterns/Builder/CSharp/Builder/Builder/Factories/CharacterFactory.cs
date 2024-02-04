using Builder.Builders;
using Builder.Characters;

namespace Builder.Factories
{
    public static class CharacterFactory
    {
        public static Player MakePlayer(PlayerBuildParameters parameters)
        {
            return new PlayerBuilder(parameters, new Player()).Build();
        }

        public static Enemy MakeEnemy(BuildParameters parameters)
        {
            return new EnemyBuilder(parameters, new Enemy()).Build();
        }
    }
}