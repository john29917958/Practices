const mongoose = require("mongoose");
const Schema = mongoose.Schema;

const BlogPostSchema = new Schema({
  title: {
    type: String,
    required: [true, "Please provide title"],
  },
  body: {
    type: String,
    required: [true, "Please provide post body"],
  },
  username: String,
  datePosted: {
    type: Date,
    default: new Date(),
  },
  image: {
    type: String,
    required: [true, "Please upload an heading image"],
  },
});

const BlogPost = mongoose.model("BlogPost", BlogPostSchema);

module.exports = BlogPost;
