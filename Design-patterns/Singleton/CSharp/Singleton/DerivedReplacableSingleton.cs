using System.Diagnostics;

namespace Singleton
{
    public class DerivedReplacableSingleton : ReplacableSingleton
    {
        public override void Operation()
        {
            Debug.WriteLine("Derived replacable singleton");
        }
    }
}