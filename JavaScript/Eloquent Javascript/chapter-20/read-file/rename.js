var fs = require("fs");
fs.createWriteStream("file-to-rename").end();
setTimeout(function () {
  fs.rename("file-to-rename", "renamed-file", function (error) {
    if (error) {
      console.log(error);
    }
  });
}, 3000);
