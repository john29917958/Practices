using AbstractFactory.UI.Banners;
using AbstractFactory.UI.Menu;
using AbstractFactory.UI.Popups;

namespace AbstractFactory.Factories
{
    public class FestivalFactory : IFactory
    {
        public Banner MakeBanner()
        {
            return new FestivalBanner();
        }

        public Menu MakeMenu()
        {
            return new FestivalMenu();
        }

        public Popup MakePopup()
        {
            return new FestivalPopup();
        }
    }
}