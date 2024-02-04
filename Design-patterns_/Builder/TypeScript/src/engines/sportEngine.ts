import { Engine } from "./engine";

class SportEngine extends Engine {
    public constructor(public name: string) {
        super(name);
    }
}

export { SportEngine };
