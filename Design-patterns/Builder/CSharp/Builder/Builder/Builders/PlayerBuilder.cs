using Builder.Characters;
using Builder.Factories;

namespace Builder.Builders
{
    public class PlayerBuildParameters : BuildParameters
    {
        public int InitialLevel;
    }

    public class PlayerBuilder : Builder<Player>
    {
        private readonly PlayerBuildParameters _parameters;

        public PlayerBuilder(PlayerBuildParameters parameters, Player player) : base(player)
        {
            _parameters = parameters;
        }

        public override void SetAttributes()
        {
            Character.X = _parameters.InitialX;
            Character.Y = _parameters.InitialY;
            Character.Name = _parameters.Name;
            Character.Health = 100;
            Character.Mana = 100;
            Character.MoveSpeed = 50;
            Character.Level = _parameters.InitialLevel;
        }

        public override void SetWeapon()
        {
            Character.Weapon = WeaponFactory.Make(_parameters.Weapon);
        }

        public override void SetAi()
        {
            Character.Ai = new Ai();
        }
    }
}