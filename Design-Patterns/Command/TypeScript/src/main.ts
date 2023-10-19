import { Application } from "./application";
import { SelectCommand } from "./commands/selectCommand";
import { Editor } from "./editor";

const app: Application = new Application();
app.createUi();
if (app.editor !== null) {
    app.editor.text = "Hello, world!";
    logSysState(app, app.editor);
    console.log("Perform operation: Select text from index 7 to 11.");
    app.executeCommand(new SelectCommand(app, app.editor, 7, 12));
    logSysState(app, app.editor);
    console.log("Perform operation: Copy.");
    app.copyButton?.click();
    logSysState(app, app.editor);
    console.log("Perform operation: Cut.");
    app.cutButton?.click();
    logSysState(app, app.editor);
    console.log("Perform operatoin: Paste.");
    app.pasteButton?.click();
    logSysState(app, app.editor);
    console.log("Perform operation: Undo.");
    app.undoButton?.click();
    logSysState(app, app.editor);
    console.log("Perform operation: Undo.");
    app.undoButton?.click();
    logSysState(app, app.editor);
}

function logSysState(app: Application, editor: Editor) {
    console.log("System information:\n" + "  Selected text: " +
        editor.getSelection() + "\n  Clipboard: " + app.clipboard +
        "\n  Editor text: " + editor.text);
}
