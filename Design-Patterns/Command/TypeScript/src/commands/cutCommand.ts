import { Application } from "../application";
import { Editor } from "../editor";
import { Command } from "./command";

class CutCommand extends Command {
    private cutText: string;

    public constructor(protected app: Application, protected editor: Editor) {
        super(app, editor);
        this.cutText = "";
    }

    public execute(): boolean {
        this.saveBackup();
        this.app.clipboard = this.editor.getSelection();
        this.editor.deleteSelection();
        return true;
    }
}

export { CutCommand };
