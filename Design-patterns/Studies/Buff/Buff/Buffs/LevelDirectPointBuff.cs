using BuffPattern.Attributeses;

namespace BuffPattern.Buffs
{
    public class LevelDirectPointBuff : DirectPointBuff
    {
        public delegate int GetLevelHandler();

        private readonly GetLevelHandler _getLevelHandler;
        private readonly IAttributes _amplifier;

        public LevelDirectPointBuff(IAttributes amounts, IAttributes amplifier, GetLevelHandler getLevelHandler, int duration = 0) : base(amounts, duration)
        {
            _getLevelHandler = getLevelHandler;
            _amplifier = amplifier;
        }

        public override void Applies(Attributes attributes, IAttributes baseAttributes)
        {
            int level = _getLevelHandler.Invoke();

            attributes.MaxHealth += Amounts.MaxHealth * level * (_amplifier.MaxHealth / 100);
            attributes.MaxMana += Amounts.MaxMana * level * (_amplifier.MaxMana / 100);
            attributes.Attack += Amounts.Attack * level * (_amplifier.Attack / 100);
            attributes.Defense += Amounts.Defense * level * (_amplifier.Defense / 100);
            attributes.Critical += Amounts.Critical * level * (_amplifier.Critical / 100);
        }
    }
}
