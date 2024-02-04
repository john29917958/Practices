import { Serializer } from "./serializer";
import { ObjToTextConverter } from "../externalLibraries/objToTextConverter";

class TextSerializer extends Serializer {
    private objToTextConverter: ObjToTextConverter;

    public constructor() {
        super();
        this.objToTextConverter = new ObjToTextConverter();
    }

    public serialize(obj: object): string {
        let serializedString = this.objToTextConverter.toText(obj);
        return serializedString;
    }
}

export { TextSerializer };
