using System;

namespace AbstractFactory.UI.Menu
{
    public class FestivalMenu : Menu
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a festival menu");
        }
    }
}