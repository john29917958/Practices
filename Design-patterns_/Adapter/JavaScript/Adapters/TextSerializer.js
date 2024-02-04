let Serializer = require("./Serializer");
let ObjToTextLibrary = require("../ExternalLibraries/ObjToTextLibrary");

class TextSerializer extends Serializer {
    #objToTextLibrary;

    constructor() {
        super();
        this.#objToTextLibrary = new ObjToTextLibrary();
    }

    serialize(obj) {
        let objText = this.#objToTextLibrary.toText(obj);
        return objText;
    }
}

module.exports = TextSerializer;
