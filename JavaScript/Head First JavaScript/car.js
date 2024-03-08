function Car(make, model, year, color, passengers, convertible, mileage) {
  this.make = make;
  this.model = model;
  this.year = year;
  this.color = color;
  this.passengers = passengers;
  this.convertible = convertible;
  this.mileage = mileage;
  this.started = false;
  this.start = function () {
    this.started = true;
  };
  this.stop = function () {
    this.started = false;
  };
  this.drive = function () {
    if (this.started) {
      console.log(this.make + " " + this.model + " goes zoom zoom!");
    } else {
      console.log("Start the engine first.");
    }
  };
}

function XCar(params) {
  this.make = params.make;
  this.model = params.model;
  this.year = params.year;
  this.color = params.color;
  this.passengers = params.passengers;
  this.convertible = params.convertible;
  this.mileage = params.mileage;
  this.started = false;
  this.start = function () {
    this.started = true;
  };
  this.stop = function () {
    this.started = false;
  };
  this.drive = function () {
    if (this.started) {
      console.log(this.make + " " + this.model + " goes zoom zoom!");
    } else {
      console.log("Start the engine first.");
    }
  };
}

let chevy = new Car("Chevy", "Bel Air", 1957, "red", 2, false, 1021);
let cadi = new Car("GM", "Cadillac", 1955, "tan", 5, false, 12892);
let fiat = new Car("Fiat", "500", 1957, "Medium Blue", 2, false, 88000);
let taxi = new Car("Webville Motors", "Taxi", 1955, "yellow", 4, false, 281341);
let testCar = new Car(
  "Webville Motors",
  "Test Car",
  2014,
  "marine",
  2,
  true,
  21
);
let cars = [chevy, cadi, taxi, fiat, testCar];
for (let i = 0; i < cars.length; i++) {
  cars[i].start();
  for (let j = 0; j < Math.floor(Math.random() * 4); j++) {
    cars[i].drive();
  }
  cars[i].stop();
}

let carParams = {
  model: "New Bel Air",
  make: "New Chevy",
  year: 1957,
  passengers: 2,
  color: "red",
  mileage: 1021,
  convertible: false,
};
let newChevyCar = new XCar(carParams);
newChevyCar.start();
for (let j = 0; j < Math.floor(Math.random() * 4); j++) {
  newChevyCar.drive();
}
newChevyCar.stop();
