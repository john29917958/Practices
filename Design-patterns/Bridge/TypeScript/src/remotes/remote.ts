import { Fan } from "../devices/fan";

abstract class Remote {
    protected constructor(protected device: Fan) {

    }

    public abstract enable(): void;

    public abstract disable(): void;
}

export { Remote };
