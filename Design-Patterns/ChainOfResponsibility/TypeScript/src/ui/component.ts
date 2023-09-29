import { ComponentWithContexualHelp } from "./componentWithContexualHelp";
import { Container } from "./container";

class Component implements ComponentWithContexualHelp {
    public set container(value: Container | null) {
        this._container = value;
    }

    private _container: Container | null;

    constructor(public toolTipText: string = "") {
        this.toolTipText = toolTipText;
        this._container = null;
    }

    showHelp(): void {
        if (this.toolTipText.length > 0) {
            console.log(this.toolTipText);
        } else {
            this._container?.showHelp();
        }
    }
}

export { Component };
