import { Dot } from "./dot";

class Circle extends Dot {
    public get radius(): number {
        return this._radius;
    }

    public set radius(value) {
        if (value < 0) {
            throw new Error("Radius must be greater or equal to 0.");
        }

        this._radius = value;
    }

    constructor(public x: number, public y: number,
        protected _radius: number) {
        super(x, y);
        this._radius = _radius;
    }

    public draw(): void {
        console.log("Draw a circle at " + this.x + ", " + this.y +
            " with radius " + this._radius + ".");
    }
}

export { Circle };
