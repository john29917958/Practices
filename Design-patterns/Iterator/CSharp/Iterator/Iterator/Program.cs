using System;
using Iterator.DesignPatternList;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatternList<Cat> list = new DesignPatternList<Cat>();
            list.Add(new Cat("Design"));
            list.Add(new Cat("Pattern"));
            
            Cat cat = new Cat("Rocks!");
            list.Add(cat);

            list.GetIterator().OnEach(OnEach);

            list.Remove(cat);

            list.GetIterator().OnEach(OnEach);

            Console.ReadLine();
        }

        private static void OnEach(Cat cat)
        {
            Console.WriteLine(cat.Name);
        }
    }
}
