using BuffPattern.Attributeses;

namespace BuffPattern.Buffs
{
    public class LevelBuff : Buff
    {
        private readonly Character _character;

        public LevelBuff(Character character)
        {
            _character = character;
        }

        public override void Applies(Attributes attributes, IAttributes baseAttributes)
        {
            attributes.MaxHealth += _character.Level * 10;
            attributes.MaxMana += _character.Level * 5;

            // Slow down the growth of combat points as level increases.
            attributes.Attack += baseAttributes.Attack / _character.Level;
            attributes.Defense += baseAttributes.Defense / _character.Level;
            attributes.Critical += baseAttributes.Critical / _character.Level;
        }
    }
}
