namespace TemplateMethod.SpellCastingValidators
{
    public class LazerSpellValidator : SpellCastingValidator
    {
        public LazerSpellValidator(Character character, Spell spell) : base(character, spell)
        {

        }

        protected override bool IsResourceEnough()
        {
            if (Character.Mana >= 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool IsSkillCooling()
        {
            if (Spell.CoolDownCounter > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool IsAnyTargetInAttackRange()
        {
            Character target = Game.RayCastCharacter(Character.Position, Vector.Front);

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
