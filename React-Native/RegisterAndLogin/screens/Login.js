import { Text, TextInput, Button } from "react-native-paper";
import { View, StyleSheet } from "react-native";
import { useState } from "react";
import { input, button } from "../styles/styles";

const Login = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [isAuthenticating, setIsAuthenticating] = useState(false);

  const handleTextChanged = function (username) {
    setUsername(username);
  };

  const handlePasswordChanged = function (password) {
    setPassword(password);
  };

  const handleLoginButtonPressed = () => {
    setIsAuthenticating(true);
  };

  return (
    <View style={styles.container}>
      <TextInput
        label="Username"
        value={username}
        onChangeText={handleTextChanged.bind(this)}
        style={input.textInput}
      />
      <TextInput
        label="Password"
        value={password}
        onChangeText={handlePasswordChanged.bind(this)}
        style={input.textInput}
        secureTextEntry={true}
      />
      <Button
        mode="elevated"
        icon="login"
        style={button.button}
        onPress={handleLoginButtonPressed.bind(this)}
        loading={isAuthenticating}
      >
        Login
      </Button>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    flexDirection: "column",
    width: "100%",
    justifyContent: "center",
  },
});

export { Login };
