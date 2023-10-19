import { Fan } from "./fan";

class BasicFan extends Fan {
    public constructor(protected fanName: string) {
        super(fanName);
    }

    public start(): void {
        console.log(`${this.fanName} has been started.`);
    }
    public stop(): void {
        console.log(`${this.fanName} has been stopped.`);
    }
}

export { BasicFan };
