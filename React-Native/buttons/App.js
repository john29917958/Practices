import { StatusBar } from "expo-status-bar";
import {
  StyleSheet,
  Text,
  View,
  Alert,
  TouchableHighlight,
  TouchableOpacity,
  TouchableNativeFeedback,
  Platform,
  TouchableWithoutFeedback,
} from "react-native";

function Touchables() {
  function handlePressedButton(buttonName) {
    Alert.alert(`You pressed the ${buttonName} button`);
  }

  function handleLongPressedButton(buttonName) {
    Alert.alert(`You long pressed the ${buttonName} button`);
  }

  return (
    <>
      <TouchableHighlight
        onPress={handlePressedButton.bind(this, "Touchable Highlight")}
        onLongPress={handleLongPressedButton.bind(this, "Touchable Highlight")}
        underlayColor="white"
      >
        <View style={styles.button}>
          <Text style={styles.buttonText}>Touchable Highlight Button</Text>
        </View>
      </TouchableHighlight>
      <TouchableOpacity
        onPress={handlePressedButton.bind(this, "Touchable Opacity")}
        onLongPress={handleLongPressedButton.bind(this, "Touchable Opacity")}
      >
        <View style={styles.button}>
          <Text style={styles.buttonText}>Touchable Opacity Button</Text>
        </View>
      </TouchableOpacity>
      {/* On Android only */}
      <TouchableNativeFeedback
        onPress={handlePressedButton.bind(this, "Touchable Native Feedback")}
        onLongPress={handleLongPressedButton.bind(
          this,
          "Touchable Native Feedback"
        )}
        background={
          Platform.OS === "android"
            ? TouchableNativeFeedback.SelectableBackground()
            : undefined
        }
      >
        <View style={styles.button}>
          <Text style={styles.buttonText}>
            Touchable Native Feedback
            {Platform.OS === "android" ? "" : " (Android only)"}
          </Text>
        </View>
      </TouchableNativeFeedback>
      <TouchableWithoutFeedback
        onPress={handlePressedButton.bind(this, "Touchable Without Feedback")}
        onLongPress={handleLongPressedButton.bind(
          this,
          "Touchable Without Feedback"
        )}
      >
        <View style={styles.button}>
          <Text style={styles.buttonText}>Touchable Without Feedback</Text>
        </View>
      </TouchableWithoutFeedback>
    </>
  );
}

export default function App() {
  return (
    <>
      <View style={styles.container}>
        <View style={styles.section}>
          <Touchables />
          <StatusBar style="auto" />
        </View>
      </View>
    </>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingLeft: 3,
    paddingRight: 3,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },

  section: {
    marginBottom: 10,
    width: "100%",
  },

  button: {
    marginBottom: 20,
    alignItems: "center",
    backgroundColor: "#2196f3",
  },

  buttonText: {
    textAlign: "center",
    padding: 20,
    color: "white",
  },
});
