var http = require("http");
var request = http.request(
  {
    hostname: "localhost",
    port: 8000,
    method: "POST",
  },
  function (response) {
    response.on("data", function (chunk) {
      process.stdout.write(chunk.toString());
    });
    response.on("end", function () {
      process.stdout.write("Response from server ended");
    });
  }
);
request.write("Hello\n");
request.end("server\n");
