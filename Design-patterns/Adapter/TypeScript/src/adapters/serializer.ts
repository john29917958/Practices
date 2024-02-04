abstract class Serializer {
    protected constructor() {

    }

    public abstract serialize(obj: object): string;
}

export { Serializer };
