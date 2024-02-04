namespace Singleton
{
    public class Client
    {
        private ReplacableSingleton _singleton;

        public Client(ReplacableSingleton singleton)
        {
            _singleton = singleton;
        }

        public void SetSingleton(ReplacableSingleton singleton)
        {
            _singleton = singleton;
        }
    }
}
