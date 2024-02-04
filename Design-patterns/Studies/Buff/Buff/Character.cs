using System.Collections.Generic;
using BuffPattern.Attributeses;
using BuffPattern.Buffs;
using BuffPattern.Equipments;

namespace BuffPattern
{
    public class Character : IAttributes, IUpdateable
    {
        public int Level { get; set; }

        public int MaxHealth => Attributes.MaxHealth;
        public int MaxMana => Attributes.MaxMana;
        public int Attack => Attributes.Attack;
        public int Defense => Attributes.Defense;
        public int Critical => Attributes.Critical;

        public BaseAttributes BaseAttributes { get; protected set; }

        public readonly List<Buff> Buffs;
        public readonly List<Equipment> Equipments;

        protected IAttributes Attributes
        {
            get
            {
                Attributes attributes = new Attributes(BaseAttributes);

                foreach (Buff buff in Buffs)
                {
                    buff.Applies(attributes, BaseAttributes);
                }

                if (attributes.MaxHealth < 0) attributes.MaxHealth = 0;
                if (attributes.MaxMana < 0) attributes.MaxMana = 0;
                if (attributes.Attack < 0) attributes.Attack = 0;
                if (attributes.Defense < 0) attributes.Defense = 0;
                if (attributes.Critical < 0) attributes.Critical = 0;

                return attributes;
            }
        }        

        public Character(int level, BaseAttributes attributes)
        {
            Level = level;
            BaseAttributes = attributes;
            Equipments = new List<Equipment>();
            Buffs = new List<Buff>();            
        }

        public void Update()
        {
            foreach (Buff buff in Buffs.ToArray())
            {
                buff.Update();
            }

            foreach (Equipment equipment in Equipments.ToArray())
            {
                equipment.Update();
            }
        }
    }
}
