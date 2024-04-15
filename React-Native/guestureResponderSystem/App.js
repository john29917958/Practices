import { StatusBar } from "expo-status-bar";
import { StyleSheet, Text, View } from "react-native";
import TouchDetector from "./touchDetector";
import DisplayArea from "./displayArea";
import { useState } from "react";

export default function App() {
  const [message, setMessage] = useState("");

  const handleOnTouchChanged = function (pos) {
    setMessage(`Fingure position: (${pos.x}, ${pos.y})`);
  };

  return (
    <View style={styles.container}>
      <TouchDetector onTouchChanged={handleOnTouchChanged} />
      <DisplayArea message={message} />
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
    paddingLeft: 20,
    paddingRight: 20,
  },
});
