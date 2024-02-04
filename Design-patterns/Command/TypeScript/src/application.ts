import { Button } from "./button";
import { CommandHistory } from "./commandHistory";
import { Command } from "./commands/command";
import { CopyCommand } from "./commands/copyCommand";
import { CutCommand } from "./commands/cutCommand";
import { PasteCommand } from "./commands/pasteCommand";
import { UndoCommand } from "./commands/undoCommand";
import { Editor } from "./editor";
import { Shortcut } from "./shortcut";

class Application {
    public editor: Editor | null;
    public clipboard: string;
    public history: CommandHistory;
    public copyButton: Button | null;
    public cutButton: Button | null;
    public pasteButton: Button | null;
    public undoButton: Button | null;
    public shortcuts: Shortcut[];

    public constructor() {
        this.clipboard = "";
        this.history = new CommandHistory();
        this.shortcuts = [];
        this.editor = null;
        this.copyButton = null;
        this.cutButton = null;
        this.pasteButton = null;
        this.undoButton = null;
    }

    public createUi(): void {
        this.editor = new Editor();
        this.copyButton = new Button(this);
        let command: Command = new CopyCommand(this, this.editor);
        this.copyButton.setCommand(command);
        let shortcut: Shortcut = new Shortcut(["Ctrl", "C"]);
        shortcut.setCommand(command);
        this.shortcuts.push(shortcut);
        this.cutButton = new Button(this);
        command = new CutCommand(this, this.editor);
        this.cutButton.setCommand(command);
        shortcut = new Shortcut(["Ctrl", "X"]);
        shortcut.setCommand(command);
        this.shortcuts.push(shortcut);
        this.pasteButton = new Button(this);
        command = new PasteCommand(this, this.editor);
        this.pasteButton.setCommand(command);
        shortcut = new Shortcut(["Ctrl", "V"]);
        shortcut.setCommand(command);
        this.shortcuts.push(shortcut);
        this.undoButton = new Button(this);
        command = new UndoCommand(this, this.editor);
        this.undoButton.setCommand(command);
        shortcut = new Shortcut(["Ctrl", "Z"]);
        shortcut.setCommand(command);
        this.shortcuts.push(shortcut);
    }

    public executeCommand(command: Command) {
        const isRevocable = command.execute();
        if (isRevocable) {
            this.history.push(command);
        }
    }

    public undo(): void {
        const command: Command | null = this.history.pop();
        if (command !== null) {
            command.undo();
        }
    }
}

export { Application };
