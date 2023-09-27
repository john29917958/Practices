class Popup {
    get themeColor() {
        return this.#themeColor;
    }

    #themeColor;

    constructor(themeColor) {
        this.#themeColor = themeColor;
    }
}

module.exports = Popup;
