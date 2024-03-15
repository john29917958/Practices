const express = require("express");
const ejs = require("ejs");
const fileUpload = require("express-fileupload");
const path = require("path");
const mongoose = require("mongoose");
const BlogPost = require("./models/BlogPost");

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

app.get("/", async (req, res) => {
  const blogPosts = await BlogPost.find({
    $or: [
      {
        title: new RegExp(req.query.keywords),
      },
      {
        body: new RegExp(req.query.keywords),
      },
    ],
  }).exec();
  res.render("index", {
    blogPosts,
  });
});
app.get("/post/:id", async (req, res) => {
  const blogPost = await BlogPost.findById(req.params.id);
  res.render("post", { blogPost });
});
app.get("/contact", (req, res) => {
  res.render("contact");
});
app.get("/about", (req, res) => {
  res.render("about");
});
app.get("/posts/new", (req, res) => {
  res.render("create");
});
app.post("/posts/store", async (req, res) => {
  const image = req.files.image;
  image.mv(path.resolve(__dirname, "public/img", image.name), async (error) => {
    await BlogPost.create({ ...req.body, image: "/img/" + image.name });
    res.redirect("/");
  });
});
app.listen(4000, () => {
  console.log("App listening on port 4000");
});
