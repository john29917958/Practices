import { CarBuilder } from "./builders/carBuilder";
import { CarManualBuilder } from "./builders/carManualBuilder";
import { Car } from "./car";
import { Director } from "./director";

const builder: CarBuilder = new CarBuilder();
const director: Director = new Director(builder);
director.make();
let car: Car = builder.getResult();
const manualBuilder: CarManualBuilder = new CarManualBuilder();
director.changeBuilder(manualBuilder);
director.make();
let carManual = manualBuilder.getResult();
