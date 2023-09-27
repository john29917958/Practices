class Menu {
    public get themeColor(): string {
        return this._themeColor;
    }

    private _themeColor: string;

    public constructor(themeColor: string) {
        this._themeColor = themeColor;
    }
}

export { Menu };
