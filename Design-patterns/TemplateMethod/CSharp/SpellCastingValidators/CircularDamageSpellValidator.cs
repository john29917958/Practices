namespace TemplateMethod.SpellCastingValidators
{
    public class CircularDamageSpellValidator : SpellCastingValidator
    {
        public CircularDamageSpellValidator(Character character, Spell spell) : base(character, spell)
        {

        }

        protected override bool IsResourceEnough()
        {
            if (Character.Health >= 10 && Character.Mana >= 90)
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
            Character target = Game.RayCastCharacter(Character.Position, 5);

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
