import { Container } from "./container";

class Panel extends Container {
    public constructor(public modalHelpText: string = "") {
        super();
        this.modalHelpText = modalHelpText;
    }

    showHelp(): void {
        if (this.modalHelpText.length > 0) {
            console.log(`Shows a modal window with help text: ${this.modalHelpText}`);
        } else {
            super.showHelp();
        }
    }
}

export { Panel };
