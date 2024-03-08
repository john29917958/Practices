function dogCatcher(obj) {
  if (obj instanceof Dog) {
    return true;
  } else {
    return false;
  }
}

function Cat(name, breed, weight) {
  this.name = name;
  this.breed = breed;
  this.weight = weight;
}
let meow = new Cat("Meow", "Siamese", 10);
let whiskers = new Cat("Whiskers", "Mixed", 12);

let fido = { name: "Fido", breed: "Mixed", weight: 38 };

function Dog(name, breed, weight) {
  this.name = name;
  this.breed = breed;
  this.weight = weight;
  this.bark = function () {
    if (this.weight > 25) {
      console.log(this.name + " says Woof!");
    } else {
      console.log(this.name + " says Yip!");
    }
  };
}
let fluffy = new Dog("Fluffy", "Poodle", 30);
let spot = new Dog("Spot", "Chihuahua", 10);
let dogs = [meow, whiskers, fido, fluffy, spot];

for (let i = 0; i < dogs.length; i++) {
  if (dogCatcher(dogs[i])) {
    console.log(dogs[i].name + " is a dog!");
  }
}
