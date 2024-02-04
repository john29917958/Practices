using AbstractFactory.UI.Banners;
using AbstractFactory.UI.Menu;
using AbstractFactory.UI.Popups;

namespace AbstractFactory.Factories
{
    public interface IFactory
    {
        Banner MakeBanner();
        Menu MakeMenu();
        Popup MakePopup();
    }
}