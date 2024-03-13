var http = require("http");
var request = http.request(
  {
    hostname: "eloquentjavascript.net",
    path: "/20_node.html",
    method: "GET",
    headers: { Accept: "text/html" },
  },
  function (response) {
    console.log("Server returned with status code: " + response.statusCode);
  }
);
request.write("Some data", function (error) {
  if (error) {
    console.log(error);
  }
});
request.end();
