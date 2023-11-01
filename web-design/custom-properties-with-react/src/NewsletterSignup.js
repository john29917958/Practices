import React from "react";
import FieldButtonGroup from "./FieldButtonGroup";

class NewsletterSignup extends React.Component {
  render() {
    return (
      <FieldButtonGroup
        type="email"
        name="newsletter"
        id="newsletter"
        labelText="E-mail address"
        buttonText="Subscribe"
        buttonBgColor="rgb(75, 97, 108)"
      />
    );
  }
}

export default NewsletterSignup;
