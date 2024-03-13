var fs = require("fs");
fs.readdir("./", "utf8", function (error, files) {
  if (error) {
    console.log(error);
  } else {
    console.log(files);
  }
});
