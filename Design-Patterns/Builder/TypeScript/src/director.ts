import { Builder } from "./builders/builder";
import { SportEngine } from "./engines/sportEngine";

class Director {
    public constructor(private builder: Builder) {

    }

    changeBuilder(builder: Builder) {
        this.builder = builder;
    }

    make() {
        this.builder.reset();
        this.builder.setSeats(2);
        this.builder.setEngine(new SportEngine("Sport Engine"));
        this.builder.setTripComputer();
        this.builder.setGPS();
    }
}

export { Director };
