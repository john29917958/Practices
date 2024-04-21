import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, View } from "react-native";
import { PaperProvider, Appbar } from "react-native-paper";
import { Home } from "./screens/Home";
import { Login } from "./screens/Login";

const loggedIn = false;

export default function App() {
  return (
    <PaperProvider>
      <Appbar.Header mode="small">
        <Appbar.Content title="LG" />
        {loggedIn ? (
          <Appbar.Action icon="logout" onPress={() => {}} />
        ) : (
          <Appbar.Action icon="account" onPress={() => {}} />
        )}
      </Appbar.Header>
      <View style={styles.container}>
        {loggedIn ? <Home /> : <Login />}
        <StatusBar style="auto" />
      </View>
    </PaperProvider>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "start",
    paddingLeft: 20,
    paddingRight: 20,
  },
});
