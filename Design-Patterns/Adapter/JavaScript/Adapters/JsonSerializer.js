let Serializer = require("./Serializer");
let JsonUtil = require("../ExternalLibraries/JsonUtil");

class JsonSerializer extends Serializer {
    #jsonUtil;

    constructor() {
        super();
        this.#jsonUtil = new JsonUtil();
    }

    serialize(obj) {
        let jsonString = this.#jsonUtil.toJson(obj);
        return jsonString;
    }
}

module.exports = JsonSerializer;
