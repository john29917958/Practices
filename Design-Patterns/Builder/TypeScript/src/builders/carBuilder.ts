import { Car } from "../car";
import { Engine } from "../engines/engine";
import { Builder } from "./builder";

class CarBuilder implements Builder {
    private car: Car;

    public constructor() {
        this.car = new Car();
    }

    reset(): void {
        this.car.numberOfSeats = 0;
        this.car.engine = null;
        this.car.tripComputer = null;
        this.car.GPS = null;
    }

    setSeats(numOfSeats: number): void {
        this.car.numberOfSeats = numOfSeats;
    }

    setEngine(engine: Engine): void {
        this.car.engine = engine;
    }

    setTripComputer(): void {
        // Set car trip computer with automated machine
        this.car.tripComputer = "Trip Computer";
    }

    setGPS(): void {
        // Set car GPS with automated machine
        this.car.GPS = "GPS";
    }

    getResult(): Car {
        return this.car;
    }
}

export { CarBuilder };
