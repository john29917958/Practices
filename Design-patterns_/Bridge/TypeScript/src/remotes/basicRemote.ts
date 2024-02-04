import { Fan } from "../devices/fan";
import { Remote } from "./remote";

class BasicRemote extends Remote {
    public constructor(protected device: Fan) {
        super(device);
    }

    public enable(): void {
        this.device.start();
    }

    public disable(): void {
        this.device.stop();
    }
}

export { BasicRemote };
