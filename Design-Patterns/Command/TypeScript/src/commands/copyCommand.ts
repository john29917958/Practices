import { Application } from "../application";
import { Editor } from "../editor";
import { Command } from "./command";

class CopyCommand extends Command {
    public constructor(protected app: Application, protected editor: Editor) {
        super(app, editor);
    }

    public execute(): boolean {
        this.app.clipboard = this.editor.getSelection();
        return false;
    }
}

export { CopyCommand };
