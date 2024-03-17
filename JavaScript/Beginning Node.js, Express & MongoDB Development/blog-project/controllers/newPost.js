module.exports = (req, res) => {
  let title = "";
  let body = "";
  let data = req.flash("data");
  console.log("New post: ", data);
  if (data && data.length > 0) {
    title = data[0].title;
    body = data[0].body;
  }
  console.log("Title = ", title);
  console.log("Body = ", body);
  res.render("create", {
    validationErrors: req.flash("validationErrors"),
    title,
    body,
  });
};
