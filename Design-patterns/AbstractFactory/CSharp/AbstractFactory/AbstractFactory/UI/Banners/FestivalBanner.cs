using System;

namespace AbstractFactory.UI.Banners
{
    public class FestivalBanner : Banner
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a festival banner");
        }
    }
}