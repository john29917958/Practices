let size = 8;
let oddChar = "#";
let evenChar = " ";
for (let i = 0; i < size; i++) {
  let line = "";
  for (let j = 0; j < size; j++) {
    if (j % 2 === 0) {
      line += evenChar;
    } else {
      line += oddChar;
    }
  }
  console.log(line);
  let charCache = oddChar;
  oddChar = evenChar;
  evenChar = charCache;
}
