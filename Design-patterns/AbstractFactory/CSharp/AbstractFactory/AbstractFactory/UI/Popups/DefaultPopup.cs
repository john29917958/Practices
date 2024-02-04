using System;

namespace AbstractFactory.UI.Popups
{
    public class DefaultPopup : Popup
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a default popup");
        }
    }
}