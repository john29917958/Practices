import { Engine } from "../engines/engine";

interface Builder {
    reset(): void;
    setSeats(numOfSeats: number): void;
    setEngine(engine: Engine): void;
    setTripComputer(): void;
    setGPS(): void;
}

export { Builder };
