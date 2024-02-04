class Editor {
    private selectionStartIndex: number;

    private selectionEndIndex: number;

    public constructor(public text: string = "") {
        this.text = text;
        this.selectionStartIndex = 0;
        this.selectionEndIndex = 0;
    }

    public select(startCharIndex: number, endCharIndex: number) {
        if (startCharIndex < 0) {
            throw new Error("Start character index should be greater or equal to 0.");
        }

        if (endCharIndex < 0) {
            throw new Error("End character index should be greater or equal to 0.");
        }

        if (endCharIndex < startCharIndex) {
            throw new Error("End character index must be greater or equal to start character index.");
        }

        this.selectionStartIndex = startCharIndex;
        this.selectionEndIndex = endCharIndex;
    }

    public getSelection(): string {
        const selectedText: string = this.text.substring(this.selectionStartIndex, this.selectionEndIndex);
        return selectedText;
    }

    public deleteSelection(): string {
        const selectedText: string = this.getSelection();
        this.text = this.text.substring(0, this.selectionStartIndex) + this.text.substring(this.selectionEndIndex);
        this.selectionEndIndex = this.selectionStartIndex;
        return selectedText;
    }

    public replaceSelection(text: string): void {
        this.text = this.text.substring(0, this.selectionStartIndex) + text + this.text.substring(this.selectionEndIndex);
        const insertionPoint: number = this.selectionStartIndex + text.length;
        this.selectionStartIndex = insertionPoint;
        this.selectionEndIndex = insertionPoint;
    }
}

export { Editor };
