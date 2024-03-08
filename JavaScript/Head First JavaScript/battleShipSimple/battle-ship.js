window.onload = function () {
  let randomLoc = Math.floor(Math.random() * 5);
  let location1 = randomLoc;
  let location2 = location1 + 1;
  let location3 = location2 + 1;
  let guess;
  let hits = 0;
  let guesses = 0;
  let isSunk = false;
  let hitLocations = [];

  while (!isSunk) {
    guess = prompt("Ready, aim fire! (enter a number from 0-6):", 1);
    if (guess < 0 || guess > 6) {
      alert("Please enter a valid cell number!");
    } else if (hitLocations.includes(Number(guess))) {
      alert(
        "You've shot this cell \"" + guess + '", please shoot another cell.'
      );
    } else {
      guess = Number(guess);
      guesses = guess + 1;
      hitLocations.push(guess);
      if (guess === location1 || guess === location2 || guess === location3) {
        alert("HIT!");
        hits++;
        if (hits === 3) {
          isSunk = true;
          alert("You sank my battleship!");
        }
      } else {
        alert("MISS!");
      }
    }
  }
  let stats =
    "You took " +
    guesses +
    " guesses to sink the battleship, " +
    "which means your shooting accuracy was " +
    3 / guesses;
  alert(stats);
};
