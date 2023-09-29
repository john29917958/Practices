class ObjToTextConverter {
    toText(obj: object): string {
        let text = "";
        for (const [key, value] of Object.entries(obj)) {
            text = text + `${key} = ${value}\n`;
        }
        return text;
    }
}

export { ObjToTextConverter };
