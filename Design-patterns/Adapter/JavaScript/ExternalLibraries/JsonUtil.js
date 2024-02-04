class JsonUtil {
    constructor() {

    }

    toJson(obj) {
        let jsonString = JSON.stringify(obj);
        return jsonString;
    }
}

module.exports = JsonUtil;
