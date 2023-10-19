import { Fan } from "./fan";

class AdvancedFan extends Fan {
    public constructor(protected fanName: string) {
        super(fanName);
    }

    public start(): void {
        console.log(`${this.fanName} has been started with cool light effect.`);
    }

    public stop(): void {
        console.log(`${this.fanName} has been started with cool light effect.`);
    }
}

export { AdvancedFan };
