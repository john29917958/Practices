using System;

namespace AbstractFactory.UI.Menu
{
    public class DefaultMenu : Menu
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a default menu");
        }
    }
}