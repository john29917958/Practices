import { Application } from "../application";
import { Editor } from "../editor";
import { Command } from "./command";

class SelectCommand extends Command {
    public constructor(protected app: Application, protected editor: Editor, private startCharIndex: number, private endCharIndex: number) {
        super(app, editor);
        this.startCharIndex = startCharIndex;
        this.endCharIndex = endCharIndex;
    }

    public execute(): boolean {
        this.editor.select(this.startCharIndex, this.endCharIndex);
        return false;
    }
}

export { SelectCommand };
