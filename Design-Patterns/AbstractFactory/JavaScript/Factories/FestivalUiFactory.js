let AbstractUiFactory = require("./AbstractUiFactory");
let Banner = require("../Ui/Banner");
let Menu = require("../Ui/Menu");
let Popup = require("../Ui/Popup");

class FestivalUiFactory extends AbstractUiFactory {
    constructor() {
        super();
    }

    createBanner() {
        let banner = new Banner("red");
        return banner;
    }

    createMenu() {
        let menu = new Menu("red");
        return menu;
    }

    createPopup() {
        let popup = new Popup("red");
        return popup;
    }
}

module.exports = FestivalUiFactory;
