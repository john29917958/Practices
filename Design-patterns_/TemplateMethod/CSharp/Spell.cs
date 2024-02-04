using System;
using TemplateMethod.SpellCastingValidators;

namespace TemplateMethod
{
    public class Spell
    {
        public float CoolDownCounter { get; protected set; }

        public SpellCastingValidator Validator
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentException();
                }
                else
                {
                    _validator = value;
                }
            }
        }

        private SpellCastingValidator _validator;

        public void Cast()
        {
            if (_validator == null || _validator.IsCastable())
            {
                Console.WriteLine("Casts spell");
            }
        }
    }
}
