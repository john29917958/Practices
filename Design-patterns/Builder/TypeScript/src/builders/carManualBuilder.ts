import { Engine } from "../engines/engine";
import { Manual } from "../manual";
import { Builder } from "./builder";

class CarManualBuilder implements Builder {
    private manual: Manual;

    public constructor() {
        this.manual = new Manual();
    }

    reset(): void {
        this.manual.numberOfSeatsDesc = "";
        this.manual.engineDesc = "";
        this.manual.tripComputerDesc = "";
        this.manual.GPSDesc = "";
    }

    setSeats(numOfSeats: number): void {
        this.manual.numberOfSeatsDesc = `Seats: ${numOfSeats}`;
    }

    setEngine(engine: Engine): void {
        this.manual.engineDesc = `Engine: ${engine.name}`;
    }

    setTripComputer(): void {
        this.manual.tripComputerDesc = "Trip computer: Basic trip computer";
    }

    setGPS(): void {
        this.manual.GPSDesc = "GPS: Basic GPS";
    }

    getResult(): Manual {
        return this.manual;
    }
}

export { CarManualBuilder };
