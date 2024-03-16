const bcrypt = require("bcrypt");
const User = require("../models/User");

module.exports = async (req, res) => {
  const { username, password } = req.body;
  User.findOne({ username })
    .exec()
    .then(
      (user) => {
        if (user) {
          bcrypt.compare(password, user.password, (error, isSame) => {
            if (isSame) {
              req.session.userId = user._id;
              res.redirect("/");
            } else {
              res.redirect("/auth/login");
            }
          });
        } else {
          res.redirect("/auth/login");
        }
      },
      (error) => {
        console.log("Login error: ", error);
      }
    );
};
