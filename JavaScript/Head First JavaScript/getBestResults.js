function getBestResults(scores, highestScore) {
  var bestSolutions = [];
  for (var i = 0; i < scores.length; i++) {
    if (scores[i] == highestScore) {
      bestSolutions.push(i);
    }
  }
  return bestSolutions;
}

var bestSolutions = getBestResults(scores, highScore);
console.log("Solutions with the highest score: " + bestSolutions);
