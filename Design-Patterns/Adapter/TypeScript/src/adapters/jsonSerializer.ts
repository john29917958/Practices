import { JsonUtil } from "../externalLibraries/jsonUtil";
import { Serializer } from "./serializer";

class JsonSerializer extends Serializer {
    private jsonUtil: JsonUtil;

    public constructor() {
        super();
        this.jsonUtil = new JsonUtil();
    }

    public serialize(obj: object): string {
        let serializedString = this.jsonUtil.toJson(obj);
        return serializedString;
    }
}

export { JsonSerializer };
