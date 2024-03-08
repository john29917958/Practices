function Duck(type, canFly) {
  this.type = type;
  this.canFly = canFly;
}

let duck = new Duck("redheaded", true);
console.log(JSON.stringify(duck, null, 2));
