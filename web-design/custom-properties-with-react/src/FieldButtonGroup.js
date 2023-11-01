import React from "react";
import "./FieldButton.css";

class FieldButtonGroup extends React.Component {
  render() {
    const buttonStyle = {
      "--button-bg-color": this.props.buttonBgColor,
    };

    return (
      <div className="FieldButtonGroup">
        <label htmlFor={this.props.id}>{this.props.labelText}</label>
        <div>
          <input
            type={this.props.type}
            name={this.props.name}
            id={this.props.id}
            onChange={this.props.onChangeHandler}
          />
          <br />
          <button type="submit" style={buttonStyle}>
            {this.props.buttonText}
          </button>
        </div>
      </div>
    );
  }
}

export default FieldButtonGroup;
