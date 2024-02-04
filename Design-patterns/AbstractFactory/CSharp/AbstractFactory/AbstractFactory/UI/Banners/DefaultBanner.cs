using System;

namespace AbstractFactory.UI.Banners
{
    public class DefaultBanner : Banner
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a default banner");
        }
    }
}