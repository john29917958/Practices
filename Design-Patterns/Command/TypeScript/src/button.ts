import { Application } from "./application";
import { Command } from "./commands/command";

class Button {
    private command: Command | null;

    constructor(private app: Application) {
        this.command = null;
    }

    public setCommand(command: Command): void {
        this.command = command;
    }

    public click(): void {
        if (this.command !== null) {
            this.app.executeCommand(this.command);
        }
    }
}

export { Button };
