using BuffPattern.Attributeses;
using BuffPattern.Buffs;

namespace BuffPattern.Equipments
{
    public class FlashArmor : Armor
    {
        private readonly Buff[] _buffs;
        private Character _character;

        public FlashArmor(string name, int level, int loading, int endurance) : base(name, level, loading, endurance)
        {
            _buffs = new Buff[]
            {
                new DirectPointBuff(new Attributes(10, 0, 0, 500, 0), 3000),
                new DirectPointBuff(new Attributes(0, 0, 0, 50, 0))
            };
        }

        public override void AttachTo(Character character)
        {
            base.AttachTo(character);

            _character = character;
            foreach (Buff buff in _buffs)
            {
                buff.AttachTo(character);
            }
        }

        public override void Detach()
        {
            base.Detach();

            foreach (Buff buff in _buffs)
            {
                _character?.Buffs.Remove(buff);
            }
        }
    }
}
