var http = require("http");
var server = http.createServer(function (req, res) {
  res.writeHead(200, { "Content-Type": "text/html" });
  res.write("<h1>Hello!</h1><p>You asked for <code>" + req.url + "</code></p>");
  res.write("<p>The method is: " + req.method + "</p>");
  for (let i = 0; i < 10; i++) {
    res.write("<p>" + i + "</p>");
  }
  res.end();
});
server.listen(8000);
