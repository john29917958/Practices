class ObjToTextLibrary {
    constructor() {

    }

    toText(obj) {
        let text = "";
        for (let [key, value] of Object.entries(obj)) {
            text = text + `Key: ${key}, value: ${value}\n`;
        }
        return text;
    }
}

module.exports = ObjToTextLibrary;
