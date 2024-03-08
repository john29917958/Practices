function makeCar() {
  var makes = ["Chevy", "GM", "Fiat", "Webville Motors", "Tucker"];
  var models = ["Cadillac", "500", "Bel-Air", "Taxi", "Torpedo"];
  var years = [1955, 1957, 1948, 1954, 1961];
  var colors = ["red", "blue", "tan", "yellow", "white"];
  var convertible = [true, false];

  var rand1 = Math.floor(Math.random() * makes.length);
  var rand2 = Math.floor(Math.random() * models.length);
  var rand3 = Math.floor(Math.random() * years.length);
  var rand4 = Math.floor(Math.random() * colors.length);
  var rand5 = Math.floor(Math.random() * 5) + 1;
  var rand6 = Math.floor(Math.random() * convertible.length);

  var car = {
    make: makes[rand1],
    model: models[rand2],
    year: years[rand3],
    color: colors[rand4],
    passengers: rand5,
    convertible: convertible[rand6],
    mileage: 0,
    started: false,
    fuel: 0,
    start: function () {
      if (this.fuel === 0) {
        console.log("The car is on empty, fill up before starting!");
      } else {
        this.started = true;
      }
    },
    stop: function () {
      this.started = false;
    },
    drive: function () {
      if (this.started) {
        if (this.fuel > 0) {
          console.log(this.make + " " + this.model + " goes zoom zoom!");
          this.fuel--;
        } else {
          console.log("Uh oh, out of fuel.");
          this.stop();
        }
      } else {
        console.log("You need to start the engine first.");
      }
    },
    addFuel: function (amount) {
      this.fuel = this.fuel + amount;
    },
  };
  return car;
}

function displayCar(car) {
  console.log(
    "Your new car is a " + car.year + " " + car.make + " " + car.model
  );
}

var car = makeCar();
displayCar(car);
car.start();
car.drive();
car.addFuel(2);
car.start();
car.drive();
car.drive();
car.drive();
car.stop();
