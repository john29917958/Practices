function Cat(name, age) {
  this.name = name;
  this.age = age;
}
Cat.prototype.meow = function () {
  console.log(this.name + " meowed.");
};
let alice = new Cat("Alice", 5);
alice.meow();
let bob = new Cat("Bob", 7);
bob.meow();
