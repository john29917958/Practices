import { Banner } from "../Ui/Banner";
import { Menu } from "../Ui/Menu";
import { Popup } from "../Ui/Popup";
import { AbstractUiFactory } from "./AbstractUiFactory";

class FestivalUiFactory extends AbstractUiFactory {
    public constructor() {
        super();
    }

    public createBanner(): Banner {
        const banner: Banner = new Banner("red");
        return banner;
    }

    public createMenu(): Menu {
        const menu: Menu = new Menu("red");
        return menu;
    }

    public createPopup(): Popup {
        const popup: Popup = new Popup("red");
        return popup;
    }
}

export { FestivalUiFactory };
