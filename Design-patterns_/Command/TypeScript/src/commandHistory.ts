import { Command } from "./commands/command";

class CommandHistory {
    private history: Command[];

    public constructor() {
        this.history = [];
    }

    public push(command: Command): number {
        this.history.push(command);
        return this.history.length;
    }

    public pop(): Command | null {
        const command: Command | undefined = this.history.pop();
        if (command === undefined) {
            return null;
        } else {
            return command;
        }
    }
}

export { CommandHistory };
