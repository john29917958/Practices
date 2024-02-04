using System;

namespace Singleton
{
    public enum SingletonTypes { Default, Derived }

    public static class SingletonFactory
    {
        private static SingletonTypes _type = SingletonTypes.Default;
        private static ReplacableSingleton _singleton;

        /// <summary>
        /// Gets the singleton that can be replaced to another type if necessary in the future.
        /// </summary>
        /// <returns>
        /// Returns a singleton object.
        /// </returns>
        public static ReplacableSingleton Get()
        {
            if (_singleton == null)
            {
                switch (_type)
                {
                    case SingletonTypes.Default:
                        _singleton = new ReplacableSingleton();
                        break;
                    case SingletonTypes.Derived:
                        _singleton = new DerivedReplacableSingleton();
                        break;
                    default:
                        throw new ArgumentException("Invalid singleton type");
                }
            }

            return _singleton;
        }
    }
}