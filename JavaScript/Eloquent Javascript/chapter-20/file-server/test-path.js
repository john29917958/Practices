// var path = require("path");
// console.log(path.relative("./", "/node_modules/"));
var fs = require("fs");
fs.stat("/", function (error, stats) {
  if (error) {
    console.log(error);
  } else {
    console.log(stats);
  }
});
fs.readdir("/Users", function (error, files) {
  console.log(files);
});
