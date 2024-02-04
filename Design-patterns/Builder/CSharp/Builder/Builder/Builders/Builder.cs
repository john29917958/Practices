using Builder.Characters;

namespace Builder.Builders
{
    public class BuildParameters
    {
        public string Name;
        public int InitialX;
        public int InitialY;
        public Weapons Weapon;
    }

    public abstract class Builder<T> where T : Character
    {
        public T Character { get; protected set; }

        protected Builder(T character)
        {
            Character = character;
        }

        public T Build()
        {
            SetAttributes();
            SetWeapon();
            SetAi();

            return Character;
        }

        public abstract void SetAttributes();
        public abstract void SetWeapon();
        public abstract void SetAi();
    }
}