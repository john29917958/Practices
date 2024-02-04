using TemplateMethod.SpellCastingValidators;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            Spell spell = new Spell();

            spell.Validator = new DefaultSpellValidator(character, spell);
            spell.Cast();

            spell.Validator = new CircularDamageSpellValidator(character, spell);
            spell.Cast();

            spell.Validator = new LazerSpellValidator(character, spell);
            spell.Cast();
        }
    }
}
