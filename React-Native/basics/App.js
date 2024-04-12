import { StatusBar } from "expo-status-bar";
import { Component } from "react";
import {
  StyleSheet,
  Text,
  View,
  Alert,
  Button,
  Image,
  TextInput,
} from "react-native";

class Cat extends Component {
  state = {
    isFed: false,
    age: null,
  };

  #handleFed = function () {
    this.setState({
      isFed: true,
    });
    Alert.alert("You've just fed the cat!");
  };

  #handleAgeInputChanged = function (text) {
    let age = Number(text);
    if (!isNaN(age)) {
      this.setState({
        age: age,
      });
    }
  };

  render() {
    return (
      <>
        <Image
          source={{
            uri: "https://picsum.photos/200/200",
          }}
          style={{
            width: 200,
            height: 200,
          }}
        ></Image>
        <Text>
          This is a cat {this.props.name},{" "}
          {this.state.age > 0 ? "I'm " + this.state.age + " year(s) old, " : ""}
          {this.state.isFed ? "I've been fed" : "I have not been fed"}
        </Text>
        <TextInput
          style={{ height: 40 }}
          placeholder="How old am I?"
          onChangeText={this.#handleAgeInputChanged.bind(this)}
          defaultValue={this.state.age ? this.state.age.toString() : ""}
        />
        <Button
          title={this.state.isFed ? "I'm fed" : "Please feed me"}
          disabled={this.state.isFed}
          onPress={this.#handleFed.bind(this)}
          color="#f44336"
        />
      </>
    );
  }
}

export default function App() {
  return (
    <View style={styles.container}>
      <Cat name="Mary" />
      <Cat name="Jack" />
      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
