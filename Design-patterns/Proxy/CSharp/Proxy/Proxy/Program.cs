using System;
using System.Threading;
using Proxy.ModelLoader;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject gameObject = new GameObject();
            IModelLoader loader = new ProxyLoader(new RealLoader());
            loader.LoadToGameObject(gameObject, "Proxy Design Pattern Rocks!");
            Console.WriteLine(gameObject.Model.Name);

            Thread.Sleep(1000);
            Console.WriteLine(gameObject.Model.Name);

            Console.ReadLine();
        }
    }
}
