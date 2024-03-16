const express = require("express");
const expressSession = require("express-session");
const ejs = require("ejs");
const fileUpload = require("express-fileupload");
const mongoose = require("mongoose");
const newPostController = require("./controllers/newPost");
const homeController = require("./controllers/home");
const getPostController = require("./controllers/getPost");
const storePostController = require("./controllers/storePost");
const newUserController = require("./controllers/newUser");
const storeUserController = require("./controllers/storeUser");
const loginController = require("./controllers/login");
const logoutController = require("./controllers/logout");
const loginUserController = require("./controllers/loginUser");
const validationMiddleWare = require("./middleware/validationMiddleware");
const authMiddleware = require("./middleware/authMiddleware");
const redirectIfAuthenticatedMiddleware = require("./middleware/redirectIfAuthenticatedMiddleware");

global.loggedIn = null;

mongoose.connect("mongodb://localhost/my_database", { useNewUrlParser: true });

const app = new express();
app.use(express.static("public"));
app.use(express.json());
app.use(expressSession({ secret: "keyboard cat" }));
app.use(express.urlencoded());
app.use(fileUpload());
app.use("/posts/store", validationMiddleWare());
app.use("*", (req, res, next) => {
  loggedIn = req.session.userId;
  next();
});

app.set("view engine", "ejs");

app.get("/", homeController);
app.get("/contact", (req, res) => {
  res.render("contact");
});
app.get("/about", (req, res) => {
  res.render("about");
});
app.get("/post/:id", getPostController);
app.get("/posts/new", authMiddleware(), newPostController);
app.post("/posts/store", authMiddleware(), storePostController);
app.get(
  "/auth/register",
  redirectIfAuthenticatedMiddleware(),
  newUserController
);
app.post(
  "/users/register",
  redirectIfAuthenticatedMiddleware(),
  storeUserController
);
app.post(
  "/users/login",
  redirectIfAuthenticatedMiddleware(),
  loginUserController
);
app.get("/auth/login", redirectIfAuthenticatedMiddleware(), loginController);
app.get("/auth/logout", authMiddleware(), logoutController);
app.use((req, res) => res.render("notfound"));

app.listen(4000, () => {
  console.log("App listening on port 4000");
});
