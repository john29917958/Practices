import { AbstractUiFactory } from "./Factories/AbstractUiFactory";
import { DefaultUiFactory } from "./Factories/DefaultUiFactory";
import { FestivalUiFactory } from "./Factories/FestivalUiFactory";
import { Banner } from "./Ui/Banner";
import { Menu } from "./Ui/Menu";
import { Popup } from "./Ui/Popup";

let uiFactory: AbstractUiFactory = new DefaultUiFactory();
let banner: Banner = uiFactory.createBanner();
let menu: Menu = uiFactory.createMenu();
let popup: Popup = uiFactory.createPopup();
uiFactory = new FestivalUiFactory();
banner = uiFactory.createBanner();
menu = uiFactory.createMenu();
popup = uiFactory.createPopup();
