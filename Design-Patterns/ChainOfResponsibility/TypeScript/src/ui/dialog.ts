import { Container } from "./container";

class Dialog extends Container {
    public constructor(public wikiPageUrl: string = "") {
        super();
        this.wikiPageUrl = wikiPageUrl;
    }

    showHelp(): void {
        if (this.wikiPageUrl.length > 0) {
            console.log(`Open a wiki page with the URL ${this.wikiPageUrl}.`);
        } else {
            super.showHelp();
        }
    }
}

export { Dialog };
