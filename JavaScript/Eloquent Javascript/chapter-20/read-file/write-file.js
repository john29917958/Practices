var fs = require("fs");
fs.writeFile("output", "Hello!", function (error) {
  if (error) {
    console.log("Failed to write file: " + error);
  } else {
    console.log("File written.");
  }
});
