"use strict";

(function () {
  let arr = [2, 1, 4, 3, 5, 9, 8, 6];
  for (let num of arr) {
    console.log(num);
  }

  for (let index in arr) {
    console.log(`${index}th element value is ${arr[index]}`);
  }
})();

let obj = {
  name: "Alice",
  gender: "Female",
  age: 23,
};

let objStr = JSON.stringify(obj);
console.log(objStr);
let arr = [2, 1, 4, 3, 5, 9, 8, 6];
for (let i = 0; i < arr.length; i++) {
  console.log(arr[i]);
}

function printMessage(message) {
  console.log(message);
}

function bark(name, age) {
  if (age > 5) {
    console.log(name + ": WOOF WOOF!");
  } else {
    console.log(name + ": woof woof!");
  }
}

function toString(obj) {
  let objStr = JSON.stringify(obj);
  console.log(objStr);
}

printMessage("Hello!");
bark("Jack", 3);
bark("Alice", 6);
bark("Lisa", 1);

toString(true);
toString(false);

function Animal(name, age) {
  this.name = name;
  this.age = age;
}
Animal.prototype.name = "Animal";

let person = new Animal("Jack", 30);
console.log(person);
let bat = new Animal("Bat", 1);
console.log(bat);
