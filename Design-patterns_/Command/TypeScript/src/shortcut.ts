import { Command } from "./commands/command";

class Shortcut {
    private command: Command | null;

    public constructor(private keys: string[]) {
        this.command = null;
        this.keys = keys;
    }

    public setCommand(command: Command): void {
        this.command = command;
    }

    public execute(): void {
        if (this.command !== null) {
            this.command.execute();
        }
    }
}

export { Shortcut };
