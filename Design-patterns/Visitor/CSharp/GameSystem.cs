using System;

namespace Visitor
{
    public static class GameSystem
    {
        public static void Instantiate(object prefab)
        {
            Console.WriteLine($"Instantiates a game object on scene.");
        }
    }
}
