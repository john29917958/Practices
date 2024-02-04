namespace TemplateMethod.SpellCastingValidators
{
    public abstract class SpellCastingValidator
    {
        protected Character Character;
        protected Spell Spell;

        protected SpellCastingValidator(Character character, Spell spell)
        {
            Character = character;
            Spell = spell;
        }

        public bool IsCastable()
        {
            if (!IsResourceEnough()) return false;
            if (IsSkillCooling()) return false;
            if (!IsAnyTargetInAttackRange()) return false;

            return true;
        }

        protected abstract bool IsResourceEnough();

        protected abstract bool IsSkillCooling();

        protected abstract bool IsAnyTargetInAttackRange();
    }
}
