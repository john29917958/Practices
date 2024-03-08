function makeCounter() {
  var count = 0;

  function counter() {
    count = count + 1;
    return count;
  }

  return counter;
}

let doCount = makeCounter();
console.log(doCount());
console.log(doCount());
console.log(doCount());
/* console.log(count); /* Would throw an error since the count variable is not
    defined. */

function makePassword(password) {
  return function (passwordGuess) {
    return passwordGuess === password;
  };
}

let authenticate = makePassword("123");
console.log(authenticate("123"));
console.log(authenticate("456"));

function multN(n) {
  return function (number) {
    return number * n;
  };
}

let mult3 = multN(3);
console.log(mult3(3)); // 9

function makeCounterObj() {
  var count = 0;

  return {
    increment: function () {
      count++;
      return count;
    },
  };
}

let counter = makeCounterObj();
console.log(counter.increment());
console.log(counter.increment());
console.log(counter.increment());
