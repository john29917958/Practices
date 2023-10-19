import { Graphic } from "./graphic";

class CompoundGraphic implements Graphic {
    private children: Graphic[];

    constructor() {
        this.children = [];
    }

    add(child: Graphic): void {
        if (!this.hasChild(child)) {
            this.children.push(child);
        }
    }

    remove(child: Graphic): void {
        const childIndex = this.children.findIndex((element: Graphic) =>
            element === child);
        if (childIndex > -1) {
            this.children.splice(childIndex, 1);
        }
    }

    hasChild(child: Graphic): boolean {
        const isChildHasBeenIncluded = this.children.includes(child);
        return isChildHasBeenIncluded;
    }

    move(x: number, y: number): void {
        for (const child of this.children) {
            child.move(x, y);
        }
    }

    draw(): void {
        for (const child of this.children) {
            child.draw();
        }
        console.log(`Draw a rectangle which contains all the children graphic
            objects.`);
    }
}

export { CompoundGraphic };
