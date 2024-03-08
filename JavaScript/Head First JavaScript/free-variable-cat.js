function Cat(name, age) {
 this.name = name;
 this.age = age;
 this.meow = function () {
   console.log(this.name + " meowed.");
 }
}
console.dir(Cat);
let cat = new Cat("Alice", 3);
console.dir(cat);