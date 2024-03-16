const BlogPost = require("../models/BlogPost");
const path = require("path");

module.exports = async (req, res) => {
  const image = req.files.image;
  image.mv(
    path.resolve(__dirname, "../", "public/img", image.name),
    (error) => {
      BlogPost.create({ ...req.body, image: "/img/" + image.name }).then(
        (blogPost) => {
          res.redirect("/");
        },
        (error) => {
          const validationErrors = Object.keys(error.errors).map(
            (key) => error.errors[key].message
          );
          let validationErrorsSession = req.flash("validationErrors") || [];
          validationErrorsSession.push(...validationErrors);
          req.flash("validationErrors", validationErrorsSession);
          res.redirect("/posts/new");
        }
      );
    }
  );
};
