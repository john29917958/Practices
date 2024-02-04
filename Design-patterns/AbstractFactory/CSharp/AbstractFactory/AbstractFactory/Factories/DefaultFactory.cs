using AbstractFactory.UI.Banners;
using AbstractFactory.UI.Menu;
using AbstractFactory.UI.Popups;

namespace AbstractFactory.Factories
{
    public class DefaultFactory : IFactory
    {
        public Banner MakeBanner()
        {
            return new DefaultBanner();
        }

        public Menu MakeMenu()
        {
            return new DefaultMenu();
        }

        public Popup MakePopup()
        {
            return new DefaultPopup();
        }
    }
}