class JsonUtil {
    toJson(obj: object): string {
        const jsonStr = JSON.stringify(obj);
        return jsonStr;
    }
}

export { JsonUtil };
