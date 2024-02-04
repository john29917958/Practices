namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplacableSingleton replacableSingleton = SingletonFactory.Get();
            Client client = new Client(replacableSingleton);
            client.SetSingleton(replacableSingleton);
        }
    }
}
