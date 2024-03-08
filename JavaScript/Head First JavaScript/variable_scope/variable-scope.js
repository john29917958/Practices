globalVariable1 = "Global variable 1";
globalVariable2 = "Global variable 2";

function doSomething() {
  globalVarDeclaredInsideFunc = "Global variable declared inside a function.";
  let localVariable1 = 0;
  let localVariable2 = "1";
  console.log(globalVariable1);
  debugger;
}

doSomething();

setTimeout(function () {
  console.log(globalVariable3);
  console.log(globalVariable4);
}, 3000);
