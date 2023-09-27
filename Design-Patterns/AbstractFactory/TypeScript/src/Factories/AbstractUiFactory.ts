import { Banner } from "../Ui/Banner";
import { Menu } from "../Ui/Menu";
import { Popup } from "../Ui/Popup";

abstract class AbstractUiFactory {
    protected constructor() {

    }

    public abstract createBanner(): Banner;

    public abstract createMenu(): Menu;

    public abstract createPopup(): Popup;
}

export { AbstractUiFactory };
