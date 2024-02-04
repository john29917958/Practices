using System;
using BuffPattern.Attributeses;

namespace BuffPattern.Buffs
{
    public class DirectPointBuff : Buff
    {
        protected readonly IAttributes Amounts;

        private readonly bool _isDurationMode;
        private readonly int _duration;
        private readonly DateTime _startTime;

        public DirectPointBuff(IAttributes amounts, int duration = 0)
        {
            Amounts = amounts;
            _duration = duration;
            _startTime = DateTime.Now;
            _isDurationMode = duration != 0;
        }

        public override void Applies(Attributes attributes, IAttributes baseAttributes)
        {
            attributes.MaxHealth += Amounts.MaxHealth;
            attributes.MaxMana += Amounts.MaxMana;
            attributes.Attack += Amounts.Attack;
            attributes.Defense += Amounts.Defense;
            attributes.Critical += Amounts.Critical;
        }

        public override void Update()
        {
            if (!_isDurationMode) return;

            if (DateTime.Now.Subtract(_startTime).TotalMilliseconds >= _duration)
            {
                Detach();
            }
        }
    }
}
