import { Application } from "../application";
import { Editor } from "../editor";
import { Command } from "./command";

class PasteCommand extends Command {
    public constructor(app: Application, protected editor: Editor) {
        super(app, editor);
    }

    public execute(): boolean {
        this.saveBackup();
        this.editor.replaceSelection(this.app.clipboard);
        return true;
    }
}

export { PasteCommand };
