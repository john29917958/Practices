import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, View } from "react-native";

function handleOnStartShouldSetResponse(evt) {
  return true;
}

function handleOnMoveShouldSetResponse(evt) {
  return true;
}

function handleOnResponderGrant(evt) {
  console.log("The touch event starts!");
  console.log(evt.nativeEvent);
}

export default function App() {
  return (
    <View style={styles.container}>
      <View style={{ marginBottom: 30 }}>
        <Text>Open up App.js to start working on your app!</Text>
      </View>
      <View
        style={{
          width: "100%",
          height: 100,
          alignItems: "center",
          justifyContent: "center",
          backgroundColor: "#00bfa5",
        }}
        onStartShouldSetResponder={handleOnStartShouldSetResponse.bind(this)}
        onMoveShouldSetResponder={handleOnMoveShouldSetResponse.bind(this)}
        onResponderGrant={handleOnResponderGrant.bind(this)}
      >
        <Text>Please touch me</Text>
      </View>
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
