function makeTea(cups, tea) {
  console.log("Brewing " + cups + " cups of " + tea);
  for (let i = 0; i < arguments.length; i++) {
    console.log("Argument " + i + " is: " + arguments[i]);
  }
}
makeTea(3, "Earl Grey", "Hey ma!", 42);
