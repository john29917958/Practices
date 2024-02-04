import { Application } from "../application";
import { Editor } from "../editor";
import { Command } from "./command";

class UndoCommand extends Command {
    public constructor(protected app: Application, protected editor: Editor) {
        super(app, editor);
    }

    public execute(): boolean {
        this.app.undo();
        return false;
    }
}

export { UndoCommand };
