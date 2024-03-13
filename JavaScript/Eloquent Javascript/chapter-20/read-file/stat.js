var fs = require("fs");
fs.stat("./stat.js", function (error, stats) {
  if (error) {
    console.log(error);
  } else {
    console.log(stats);
  }
});
