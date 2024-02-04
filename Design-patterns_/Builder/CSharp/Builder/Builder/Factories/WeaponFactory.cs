using Builder.Characters;

namespace Builder.Factories
{
    public static class WeaponFactory
    {
        public static Weapon Make(Weapons type)
        {
            return new Weapon();
        }
    }
}