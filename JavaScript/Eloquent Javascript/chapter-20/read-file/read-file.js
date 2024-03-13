var fs = require("fs");
fs.readFile("file", "utf8", function (error, data) {
  if (error) {
    throw error;
  }
  console.log(data);
});
fs.readFile("file", function (error, data) {
  if (error) {
    throw error;
  }
  console.log(data);
});
