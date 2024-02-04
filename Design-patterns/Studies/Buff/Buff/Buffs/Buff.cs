using BuffPattern.Attributeses;

namespace BuffPattern.Buffs
{
    public abstract class Buff : IUpdateable
    {
        private Character _character;

        public abstract void Applies(Attributes attributes, IAttributes baseAttributes);

        public void AttachTo(Character character)
        {
            _character = character;
            character.Buffs.Add(this);
        }

        public void Detach()
        {
            _character?.Buffs.Remove(this);
        }

        public virtual void Update()
        {
            
        }
    }
}
