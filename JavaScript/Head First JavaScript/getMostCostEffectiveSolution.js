function getMostCostEffectiveSolution(scores, costs, highScore) {
  let cost = 100;
  let index;
  for (var i = 0; i < scores.length; i++) {
    if (scores[i] === highScore) {
      if (cost > costs[i]) {
        index = i;
        cost = costs[i];
      }
    }
  }
  return index;
}
var mostCostEffective = getMostCostEffectiveSolution(scores, costs, highScore);
console.log(
  "Bubble Solution #" + mostCostEffective + " is the most cost effective"
);
