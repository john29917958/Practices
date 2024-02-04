import { Circle } from "./circle";
import { CompoundGraphic } from "./compoundGraphic";
import { Dot } from "./dot";
import { Graphic } from "./graphic";

class ImageEditor {
    public get all(): CompoundGraphic | null {
        return this._all;
    }

    private _all: CompoundGraphic | null;

    constructor() {
        this._all = null;
    }

    public load(): void {
        this._all = new CompoundGraphic();
        const dot: Dot = new Dot(1, 2);
        const circle: Circle = new Circle(5, 3, 10);
        this._all.add(dot);
        this._all.add(circle);
    }

    public groupSelected(components: Graphic[]): void {
        const group: CompoundGraphic = new CompoundGraphic();
        for (const component of components) {
            group.add(component);
            this._all?.remove(component);
        }
        this._all?.add(group);
        this._all?.draw();
    }
}

export { ImageEditor };
