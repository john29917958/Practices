abstract class Fan {
    public get name() {
        return this.fanName;
    }

    protected constructor(protected fanName: string) {
        this.fanName = fanName;
    }

    public abstract start(): void;

    public abstract stop(): void;
}

export { Fan };
