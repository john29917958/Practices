let AbstractUiFactory = require("./AbstractUiFactory");
let Banner = require("../Ui/Banner");
let Menu = require("../Ui/Menu");
let Popup = require("../Ui/Popup");

class DefaultUiFactory extends AbstractUiFactory {
    constructor() {
        super();
    }

    createBanner() {
        let banner = new Banner("lightgray");
        return banner;
    }

    createMenu() {
        let menu = new Menu("lightgray");
        return menu;
    }

    createPopup() {
        let popup = new Popup("lightgray");
        return popup;
    }
}

module.exports = DefaultUiFactory;
