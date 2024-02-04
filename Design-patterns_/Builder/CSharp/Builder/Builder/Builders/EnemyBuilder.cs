using Builder.Characters;
using Builder.Factories;

namespace Builder.Builders
{
    public class EnemyBuilder : Builder<Enemy>
    {
        private readonly BuildParameters _parameters;

        public EnemyBuilder(BuildParameters parameters, Enemy character) : base(character)
        {
            _parameters = parameters;
        }

        public override void SetAttributes()
        {
            Character.X = _parameters.InitialX;
            Character.Y = _parameters.InitialY;
            Character.Name = _parameters.Name;
            Character.Health = 500;
            Character.Mana = 1000;
            Character.MoveSpeed = 30;
        }

        public override void SetWeapon()
        {
            Character.Weapon = WeaponFactory.Make(Weapons.Gun);
        }

        public override void SetAi()
        {
            Character.Ai = new Ai();
        }
    }
}