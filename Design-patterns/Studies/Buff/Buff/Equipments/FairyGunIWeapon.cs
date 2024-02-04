using BuffPattern.Attributeses;
using BuffPattern.Buffs;

namespace BuffPattern.Equipments
{
    public class FairyGunIWeapon : Weapon
    {
        private readonly DirectPointBuff _buff;
        private Character _character;

        public FairyGunIWeapon(string name, int level, int loading, int endurance) : base(name, level, loading, endurance)
        {
            _buff = new LevelDirectPointBuff(new Attributes(0, 0, 10, 0, 1), new Attributes(0, 0, 100, 0, 100), () => Level);
        }

        public override void AttachTo(Character character)
        {
            base.AttachTo(character);

            _character = character;
            character.Buffs.Add(_buff);
        }

        public override void Detach()
        {
            base.Detach();
            _character?.Buffs.Remove(_buff);
        }
    }
}
