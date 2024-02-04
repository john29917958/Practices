using System;
using Adapter.Adapters;

namespace Adapter
{
    class Args
    {
        public string Name => "Design pattern";

        public string Description => "Rocks";

        public int Number => 100;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISerializer[] serializers =
            {
                new TextSerializer(),
                new JsonSerializer()
            };

            Args obj = new Args();

            foreach (ISerializer serializer in serializers)
            {
                string str = serializer.Serialize(obj);
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }
    }
}
