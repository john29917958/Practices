/*
Comparison rules:
1: Place first item after second item
0: Items are equivalent
-1: Place first item before second item

===

Returns 1 to place first item after second item
Returns 0 to not changing order of two items
Returns -1 to place first item before second item
*/

/* When do the sort function has to place the first item after the second item
so the numbers are sorted in descending order?
Ans: When the first item is less than the second item. */
let numbersArray = [60, 50, 62, 58, 54, 54];
numbersArray.sort(compareNumbers);
console.log(numbersArray);
numbersArray.sort(compareNumbersDesc);
console.log(numbersArray);
numbersArray.sort(compareNumbersDescShort);
console.log(numbersArray);

function compareNumbers(num1, num2) {
  return num1 - num2;
}

function compareNumbersDesc(num1, num2) {
  if (num2 > num1) {
    return 1;
  } else if (num1 === num2) {
    return 0;
  } else {
    return -1;
  }
}

function compareNumbersDescShort(num1, num2) {
  return num2 - num1;
}

let products = [
  { name: "Grapefruit", calories: 170, color: "red", sold: 8200 },
  { name: "Orange", calories: 160, color: "orange", sold: 12101 },
  { name: "Cola", calories: 210, color: "caramel", sold: 25412 },
  { name: "Diet Cola", calories: 0, color: "caramel", sold: 43922 },
  { name: "Lemon", calories: 200, color: "clear", sold: 14983 },
  { name: "Raspberry", calories: 180, color: "pink", sold: 9427 },
  { name: "Root Beer", calories: 200, color: "caramel", sold: 9909 },
  { name: "Water", calories: 0, color: "clear", sold: 62123 },
];

products.sort(compareName);
console.log("Sort by name: ", JSON.stringify(products, null, 2));
products.sort(compareCalories);
console.log("Sort by calories: ", JSON.stringify(products, null, 2));
products.sort(compareColor);
console.log("Sort by color: ", JSON.stringify(products, null, 2));
products.sort(compareSold);
console.log("Sort by sold: ", JSON.stringify(products, null, 2));
products.sort(compareSoldShort);
console.log(
  "Sort by sold (short version): ",
  JSON.stringify(products, null, 2)
);

function compareName(colaA, colaB) {
  if (colaA.name > colaB.name) {
    return 1;
  } else if (colaA.name === colaB.name) {
    return 0;
  } else {
    return -1;
  }
}

function compareCalories(colaA, colaB) {
  if (colaA.calories > colaB.calories) {
    return 1;
  } else if (colaA.calories === colaB.calories) {
    return 0;
  } else {
    return -1;
  }
}

function compareColor(colaA, colaB) {
  if (colaA.color > colaB.color) {
    return 1;
  } else if (colaA.color === colaB.color) {
    return 0;
  } else {
    return -1;
  }
}

function compareSold(colaA, colaB) {
  if (colaA.sold > colaB.sold) {
    return 1;
  } else if (colaA.sold === colaB.sold) {
    return 0;
  } else {
    return -1;
  }
}

function compareSoldShort(colaA, colaB) {
  return colaA.sold - colaB.sold;
}
