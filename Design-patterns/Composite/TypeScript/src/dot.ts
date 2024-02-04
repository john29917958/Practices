import { Graphic } from "./graphic";

class Dot implements Graphic {
    constructor(public x: number, public y: number) {
        this.x = x;
        this.y = y;
    }

    move(x: number, y: number): void {
        this.x = this.x + x;
        this.y = this.y + y;
    }

    draw(): void {
        console.log("Draw a dot at " + this.x + ", " + this.y + ".");
    }

}

export { Dot };
