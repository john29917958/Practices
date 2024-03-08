function Dog(name, breed, weight) {
  this.name = name;
  this.breed = breed;
  this.weight = weight;
}
Dog.prototype.species = "Canine";
Dog.prototype.bark = function () {
  if (this.weight > 25) {
    console.log(this.name + " says Woof!");
  } else {
    console.log(this.name + " says Yip!");
  }
};
Dog.prototype.run = function () {
  console.log("Run!");
};
Dog.prototype.wag = function () {
  console.log("Wag!");
};
var fido = new Dog("Fido", "Mixed", 38);
var fluffy = new Dog("Fluffy", "Poodle", 30);
var spot = new Dog("Spot", "Chihuahua", 10);
spot.bark = function () {
  console.log(this.name + " says WOOF!");
};
var dogs = [fido, fluffy, spot];

for (let i = 0; i < dogs.length; i++) {
  let size = "small";
  if (dogs[i].weight > 10) {
    size = "large";
  }
  console.log("Dog: " + dogs[i].name + " is a " + size + " " + dogs[i].breed);
  dogs[i].bark();
}

fido.bark();
fido.run();
fido.wag();
fluffy.bark();
fluffy.run();
fluffy.wag();
spot.bark();
spot.run();
spot.wag();

Dog.prototype.sitting = false;
Dog.prototype.sit = function () {
  if (this.sitting) {
    console.log(this.name + " is already sitting.");
  } else {
    this.sitting = true; /* Set to object instance, not set to the prototype,
        thus override (hides in my point of view) the sitting property in the
        prototype. */
    console.log(this.name + " is now sitting.");
  }
};
console.log(
  "Does fido has own property sitting?",
  fido.hasOwnProperty("sitting")
); // false
fido.sit();
console.log(
  "Does fido has own property sitting?",
  fido.hasOwnProperty("sitting")
); // true
fido.sit();
console.log(
  "Does fluffy has own property sitting?",
  fluffy.hasOwnProperty("sitting")
); // false
fluffy.sit();
console.log(
  "Does fluffy has own property sitting?",
  fluffy.hasOwnProperty("sitting")
); // true
fluffy.sit();

function ShowDog(name, breed, weight, handler) {
  Dog.call(this, name, breed, weight);
  this.handler = handler;
}

ShowDog.prototype = new Dog();
// ShowDog.prototype = Dog.prototype; // This seems like also works!
// Object.setPrototypeOf(ShowDog.prototype, Dog.prototype); // From MDN: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Inheritance_and_the_prototype_chain
ShowDog.prototype.constructor = ShowDog;

ShowDog.prototype.league = "Webville";

ShowDog.prototype.stack = function () {
  console.log("Stack");
};

ShowDog.prototype.bait = function () {
  console.log("Bait");
};

ShowDog.prototype.gait = function (kind) {
  console.log(kind + "ing");
};

ShowDog.prototype.groom = function () {
  console.log("Groom");
};

let scotty = new ShowDog("Scotty", "Scottish Terrier", 15, "Cookie");
let beatrice = new ShowDog("Beatrice", "Pomeranian", 5, "Hamilton");

scotty.stack();
scotty.bark();
console.log(scotty.league);
console.log(scotty.species);

if (fido instanceof Dog) {
  console.log("Fido is a Dog");
}
if (fido instanceof ShowDog) {
  console.log("Fido is a ShowDog");
}
if (scotty instanceof Dog) {
  console.log("Scotty is a Dog");
}
if (scotty instanceof ShowDog) {
  console.log("Scotty is a ShowDog");
}
console.log("Fido constructor is " + fido.constructor);
console.log("Scotty constructor is " + scotty.constructor);

fido.bark();
fluffy.bark();
spot.bark();
scotty.bark();
beatrice.bark();
scotty.gait("Walk");
beatrice.groom();
