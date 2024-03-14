var fs = require("fs");
var Promise = require("promise");

var readFile = Promise.denodeify(fs.readFile);
readFile("file", "utf8").then(
  function (content) {
    console.log("The file contained: " + content);
  },
  function (error) {
    console.log("Failed to read file: " + error);
  }
);
