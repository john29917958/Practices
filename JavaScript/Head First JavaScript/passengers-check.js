var passengers = [
  { name: "Jane Doloop", paid: true, ticket: "coach" },
  { name: "Dr. Evel", paid: true, ticket: "firstclass" },
  { name: "Sue Property", paid: false, ticket: "firstclass" },
  { name: "John Funcall", paid: true, ticket: "premium" },
];

var noFlyList = ["Dr. Evel"];

function checkNoFlyList(passenger) {
  if (noFlyList.includes(passenger.name)) {
    return true;
  } else {
    return false;
  }
}

function checkNotPaid(passenger) {
  return !passenger.paid;
}

function processPassengers(passengers, testFunction) {
  for (let i = 0; i < passengers.length; i++) {
    if (testFunction(passengers[i])) {
      return false;
    }
  }
  return true;
}

function printPassenger(passenger) {
  console.log(passenger.name);
  return false;
}

function serverPassengers(passengers) {
  for (let passenger of passengers) {
    serveCustomer(passenger);
  }
}

function serveCustomer(passenger) {
  let getDrinkOrderFunc = createDrinkOrder(passenger);
  let getDinnerOrderFunc = createDinnerOrder(passenger);
  getDrinkOrderFunc();
  getDrinkOrderFunc();
  getDrinkOrderFunc();
  getDinnerOrderFunc();
  getDinnerOrderFunc();
}

function createDrinkOrder(passenger) {
  let orderFunction;
  if (passenger.ticket === "firstclass") {
    orderFunction = function () {
      console.log("Would you like a cocktail or wine?");
    };
  } else if (passenger.ticket === "premium") {
    orderFunction = function () {
      console.log("Would you like wine, cola or water?");
    };
  } else if (passenger.ticket === "coach") {
    orderFunction = function () {
      console.log("Your choice is cola or water?");
    };
  } else {
    orderFunction = function () {
      console.log(
        "Sorry, ticket " +
          passenger.ticket +
          " is not supported for drink service."
      );
    };
  }
  return orderFunction;
}

function createDinnerOrder(passenger) {
  let orderFunction;
  if (passenger.ticket === "firstclass") {
    orderFunction = function () {
      console.log("Would you like chicken or pasta?");
    };
  } else if (passenger.ticket === "premium") {
    orderFunction = function () {
      console.log("Would you like snack box or cheese plate?");
    };
  } else if (passenger.ticket === "coach") {
    orderFunction = function () {
      console.log("Would you like peanuts or pretzels?");
    };
  } else {
    orderFunction = function () {
      console.log(
        "Sorry, ticket " +
          passenger.ticket +
          " is not supported for dinner service."
      );
    };
  }
  return orderFunction;
}

let allCanFly = processPassengers(passengers, checkNoFlyList);
if (!allCanFly) {
  console.log(
    "The plane can't take off: we have a passenger on the no-fly list."
  );
}

let allPaid = processPassengers(passengers, checkNotPaid);
if (!allPaid) {
  console.log("The plane can't take off: not everyone has paid.");
}

processPassengers(passengers, printPassenger);
serverPassengers(passengers);
