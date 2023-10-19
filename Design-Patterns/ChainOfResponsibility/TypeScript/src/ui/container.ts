import { Component } from "./component";

class Container extends Component {
    private children: Component[];

    public constructor() {
        super();
        this.children = [];
    }

    public add(child: Component) {
        if (!this.children.includes(child)) {
            this.children.push(child);
            child.container = this;
        }
    }
}

export { Container };
