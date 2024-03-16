module.exports = (req, res) => {
  res.render("create", {
    validationErrors: req.flash("validationErrors"),
  });
};
