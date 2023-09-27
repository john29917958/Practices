import { Banner } from "../Ui/Banner";
import { Menu } from "../Ui/Menu";
import { Popup } from "../Ui/Popup";
import { AbstractUiFactory } from "./AbstractUiFactory";

class DefaultUiFactory extends AbstractUiFactory {
    public constructor() {
        super();
    }

    public createBanner(): Banner {
        const banner: Banner = new Banner("white");
        return banner;
    }

    public createMenu(): Menu {
        const menu: Menu = new Menu("white");
        return menu;
    }

    public createPopup(): Popup {
        const popup: Popup = new Popup("white");
        return popup;
    }
}

export { DefaultUiFactory };
