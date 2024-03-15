const express = require("express");
const ejs = require("ejs");
const path = require("path");
const mongoose = require("mongoose");
const BlogPost = require("./models/BlogPost");

mongoose.connect("mongodb://localhost/my_database", { useNewUrlParser: true });

const app = new express();

app.use(express.static("public"));
app.use(express.json());
app.use(express.urlencoded());

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
  console.log(req.params);
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
  await BlogPost.create(req.body);
  res.redirect("/");
});
app.listen(4000, () => {
  console.log("App listening on port 4000");
});
