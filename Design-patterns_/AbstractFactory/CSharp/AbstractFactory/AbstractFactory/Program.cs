using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new DefaultFactory();
            factory.MakeBanner().ShowWhichUiIAm();
            factory.MakeMenu().ShowWhichUiIAm();
            factory.MakePopup().ShowWhichUiIAm();

            factory = new FestivalFactory();
            factory.MakeBanner().ShowWhichUiIAm();
            factory.MakeMenu().ShowWhichUiIAm();
            factory.MakePopup().ShowWhichUiIAm();

            Console.ReadLine();
        }
    }
}
