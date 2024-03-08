function Dog(name) {
  this.name = name;
}

Dog.prototype.bark = function () {
  console.log(this.name + " says woof woof.");
};

let jack = new Dog("Jack");
jack.bark();
// jack.sit(); // Error

Dog.prototype.sit = function () {
  console.log(this.name + " now sits");
};

jack.sit();
