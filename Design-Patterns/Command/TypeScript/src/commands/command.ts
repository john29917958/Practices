import { Application } from "../application";
import { Editor } from "../editor";

abstract class Command {
    protected backup: string;

    protected constructor(protected app: Application, protected editor: Editor) {
        this.app = app;
        this.editor = editor;
        this.backup = "";
    }

    public saveBackup(): void {
        this.backup = this.editor.text;
    }

    public undo(): void {
        this.editor.text = this.backup;
    }

    public abstract execute(): boolean;
}

export { Command };
