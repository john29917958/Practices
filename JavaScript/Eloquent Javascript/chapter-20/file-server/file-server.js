var http = require("http");
var fs = require("fs");
var path = require("path");

var methods = Object.create(null);
methods.GET = function (path, respond) {
  fs.stat(path, function (error, stats) {
    if (error && error.code === "ENOENT") {
      respond(404, "File not found");
    } else if (error) {
      respond(500, error.toString());
    } else if (stats.isDirectory()) {
      fs.readdir(path, function (error, files) {
        if (error) {
          respond(500, error.toString());
        } else {
          respond(200, files.join("\n"));
        }
      });
    } else {
      respond(
        200,
        fs.createReadStream(path),
        require("mime-types").lookup(path)
      );
    }
  });
};
methods.DELETE = function (path, respond) {
  fs.stat(path, function (error, stats) {
    if (error && error.code === "ENOENT") {
      respond(204);
    } else if (error) {
      respond(500, error.toString());
    } else if (stats.isDirectory()) {
      fs.rmdir(path, respondErrorOrNothing(respond));
    } else {
      fs.unlink(path, respondErrorOrNothing(respond));
    }
  });
};
methods.PUT = function (path, respond, request) {
  var outStream = fs.createWriteStream(path);
  outStream.on("error", function (error) {
    respond(500, error.toString());
  });
  outStream.on("finish", function () {
    respond(204);
  });
  request.pipe(outStream);
};
methods.MKCOL = function (path, respond) {
  if (fs.existsSync(path)) {
    respond(204);
  } else {
    fs.mkdir(path, function (error) {
      if (error) {
        respond(500, error.toString());
      } else {
        respond(204);
      }
    });
  }
};

function respondErrorOrNothing(respond) {
  return function (error) {
    if (error) {
      respond(500, error.toString());
    } else {
      respond(204);
    }
  };
}

http
  .createServer(function (req, res) {
    function respond(code, body, type) {
      if (!type) {
        type = "text/plain";
      }
      res.writeHead(code, { "Content-Type": type });
      if (body && body.pipe) {
        body.pipe(res);
      } else {
        res.end(body);
      }
    }
    if (req.method in methods) {
      methods[req.method](urlToPath(req.url), respond, req);
    } else {
      respond(405, "Method " + req.method + " not allowed.");
    }
  })
  .listen(8000);

function urlToPath(url) {
  var pathname = require("url").parse(url).pathname;
  pathname = path.join(__dirname, pathname);
  pathname = decodeURIComponent(pathname);
  return pathname;
}
