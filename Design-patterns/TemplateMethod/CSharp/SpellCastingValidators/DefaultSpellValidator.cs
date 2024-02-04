namespace TemplateMethod.SpellCastingValidators
{
    public class DefaultSpellValidator : SpellCastingValidator
    {
        public DefaultSpellValidator(Character character, Spell spell) : base(character, spell)
        {

        }

        protected override bool IsResourceEnough()
        {
            // No HP or MP restriction for default spell.
            return true;
        }

        protected override bool IsSkillCooling()
        {
            // No cooling time for default spell.
            return false;
        }

        protected override bool IsAnyTargetInAttackRange()
        {
            // Checks any character in melee range.
            Vector front = Vector.Front;
            front.Z = 1;

            Character target = Game.RayCastCharacter(Character.Position, front);

            if (target == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
