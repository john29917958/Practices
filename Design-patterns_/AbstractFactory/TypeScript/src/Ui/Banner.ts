class Banner {
    public get themeColor(): string {
        return this._themeColor;
    }

    public constructor(private _themeColor: string) {
        this._themeColor = _themeColor;
    }
}

export { Banner };
