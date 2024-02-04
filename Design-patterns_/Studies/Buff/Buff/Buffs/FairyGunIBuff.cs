using System;
using BuffPattern.Attributeses;
using BuffPattern.Equipments;

namespace BuffPattern.Buffs
{
    public class FairyGunIBuff : Buff
    {
        private readonly Weapon _weapon;

        public FairyGunIBuff(Weapon weapon)
        {
            _weapon = weapon;
        }

        public override void Applies(Attributes attributes, IAttributes baseAttributes)
        {
            attributes.Attack += Convert.ToInt32(baseAttributes.Attack * 0.2 * _weapon.Level);
            attributes.Critical += Convert.ToInt32(baseAttributes.Critical * 0.01 * _weapon.Level);
        }
    }
}
