import { Engine } from "./engines/engine";

class Car {
    public numberOfSeats: number = 0;
    public engine: Engine | null = null;
    public tripComputer: string | null = null;
    public GPS: string | null = null;
}

export { Car };
