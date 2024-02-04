using Builder.Builders;
using Builder.Characters;
using Builder.Factories;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = CharacterFactory.MakePlayer(new PlayerBuildParameters
            {
                InitialX = 0,
                InitialY = 0,
                Name = "John",
                Weapon = Weapons.Sword,
                InitialLevel = 1
            });

            character = CharacterFactory.MakeEnemy(new BuildParameters
            {
                InitialX = 0,
                InitialY = 0,
                Name = "Spider",
                Weapon = Weapons.Gun
            });
        }
    }
}
