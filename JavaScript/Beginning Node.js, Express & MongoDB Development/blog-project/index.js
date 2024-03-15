const express = require("express");
const ejs = require("ejs");
const fileUpload = require("express-fileupload");
const mongoose = require("mongoose");
const newPostController = require("./controllers/newPost");
const homeController = require("./controllers/home");
const getPostController = require("./controllers/getPost");
const storePostController = require("./controllers/storePost");

mongoose.connect("mongodb://localhost/my_database", { useNewUrlParser: true });

const app = new express();
app.use(express.static("public"));
app.use(express.json());
app.use(express.urlencoded());
app.use(fileUpload());

const validateMiddleWare = () => {
  return (req, res, next) => {
    if (req.files === null || req.body.title === null) {
      return res.redirect("/posts/new");
    }
    next();
  };
};
app.use("/posts/store", validateMiddleWare());

app.set("view engine", "ejs");

app.get("/", homeController);
app.get("/contact", (req, res) => {
  res.render("contact");
});
app.get("/about", (req, res) => {
  res.render("about");
});
app.get("/post/:id", getPostController);
app.get("/posts/new", newPostController);
app.post("/posts/store", storePostController);
app.listen(4000, () => {
  console.log("App listening on port 4000");
});
