using System;

namespace AbstractFactory.UI.Popups
{
    public class FestivalPopup : Popup
    {
        public override void ShowWhichUiIAm()
        {
            Console.WriteLine("I'm a festival popup");
        }
    }
}