/*
JavaScript Bubble-R-Us Report Pseudocode
===
Algorithm: Bubble-R-Us Report
Inputs: An array of all bubble solutions' scores S.
Output: None. This prints results to the console.
---
highestScore <- 0
highestScoreSolutionNos <- []
for each score number and score in S
    Print the solution number and the corresponding score in the format: Bubble solution #<solution number> score: <score>
    if score > (is larger than) highestScore, then
        highestScore <- score
for each score number and score in S
    if score = (equals to) highestScore, then
        Push score number to highestScoreSolutionNos
Print numbers of bubble solutions
Print highest score
Print solutions with highest score
===
Problem: What is the solution that can generate the highest price-performance ratio (score / cost)?
Algorithm: Get highest price-performance ratio solution number
Inputs: An array of bubble solutions S, and an array of bubble solutions' costs C.
Output: The numbers of the highest price-performance ratio solutions as an array.
---
highestPricePerformanceRatio <- 0
highestPerformanceRatioSolutions <- []
for index of indecies of solutions
  pricePerformanceRatio <- bubbleScores[i] / costs[i]
  if pricePerformanceRatio > highestPricePerformanceRatio
    highestPricePerformanceRatio <- pricePerformanceRatio
for index of indecies of solutions
  pricePerformanceRatio <- bubbleScores[i] / costs[i]
  if pricePerformanceRatio = highestPricePerformanceRatio
    Push i to highestPerformanceRatioSolutions
return highestPerformanceRatioSolutions
*/
function printBubbleRUsReport(bubbleScores) {
  printScores(bubbleScores);
  let highestScore = getHighestScore(bubbleScores);
  let bestSolutions = getBestSolutions(bubbleScores, highestScore);
  console.log(`Bubbles tests: ${bubbleScores.length}`);
  console.log(`Highest bubble score: ${highestScore}`);
  console.log(`Solutions with highest score: #${bestSolutions.join(", #")}`);
}

function printScores(scores) {
  for (let i = 0; i < scores.length; i++) {
    console.log(`Bubble solution #${i} score: ${scores[i]}`);
  }
}

function getHighestScore(scores) {
  let highestScore = 0;
  for (let i = 0; i < scores.length; i++) {
    if (scores[i] > highestScore) {
      highestScore = scores[i];
    }
  }
  return highestScore;
}

function getBestSolutions(bubbleScores, highestScore) {
  let bestSolutions = [];
  for (let i = 0; i < bubbleScores.length; i++) {
    if (bubbleScores[i] === highestScore) {
      bestSolutions.push(i);
    }
  }
  return bestSolutions;
}

function getHighestPricePerformanceRatioSolutionsNos(bubbleScores, costs) {
  let highestPricePerformanceRatio = 0;
  let highestPricePerformanceRatioSolutionsNos = [];
  for (let i = 0; i < bubbleScores.length; i++) {
    let pricePerformanceRatio = bubbleScores[i] / costs[i];
    if (pricePerformanceRatio > highestPricePerformanceRatio) {
      highestPricePerformanceRatio = pricePerformanceRatio;
    }
  }
  for (let i = 0; i < bubbleScores.length; i++) {
    let pricePerformanceRatio = bubbleScores[i] / costs[i];
    if (pricePerformanceRatio === highestPricePerformanceRatio) {
      highestPricePerformanceRatioSolutionsNos.push(i);
    }
  }
  return highestPricePerformanceRatioSolutionsNos;
}

let bubbleScores = [
  60, 50, 60, 58, 54, 54, 58, 50, 52, 54, 48, 69, 34, 55, 51, 52, 44, 51, 69,
  64, 66, 55, 52, 61, 46, 31, 57, 52, 44, 18, 41, 53, 55, 61, 51, 44,
];
printBubbleRUsReport(bubbleScores);
let costs = [
  0.25, 0.27, 0.25, 0.25, 0.25, 0.25, 0.33, 0.31, 0.25, 0.29, 0.27, 0.22, 0.31,
  0.25, 0.25, 0.33, 0.21, 0.25, 0.25, 0.25, 0.28, 0.25, 0.24, 0.22, 0.2, 0.25,
  0.3, 0.25, 0.24, 0.25, 0.25, 0.25, 0.27, 0.25, 0.26, 0.29,
];
let bestCostEffectiveSolutions = getHighestPricePerformanceRatioSolutionsNos(
  bubbleScores,
  costs
);
console.log(
  bestCostEffectiveSolutions.length > 0
    ? "#" + bestCostEffectiveSolutions.join(", #")
    : ""
);
