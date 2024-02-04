import { Fan } from "../devices/fan";
import { Remote } from "./remote";

class AdvancedRemote extends Remote {
    public constructor(device: Fan) {
        super(device);
    }

    public enable(): void {
        console.log(`Start the ${this.device.name} with cool light effect.`);
        this.device.start();
    }

    public disable(): void {
        console.log(`Stop the ${this.device.name} with cool light effect.`);
        this.device.stop();
    }
}

export { AdvancedRemote };
