const User = require("../models/User");
const path = require("path");

module.exports = (req, res) => {
  User.create(req.body).then(
    (user) => {
      console.log(user);
      res.redirect("/");
    },
    (error) => {
      console.log(error);
      res.redirect("/auth/register");
    }
  );
};
