import { useState } from "react";
import { View, Text, StyleSheet } from "react-native";

function handleOnStartShouldSetResponse(evt) {
  return true;
}

function handleOnMoveShouldSetResponse(evt) {
  return true;
}

const getTouchPosition = function (nativeEvent) {
  let x = Math.round(nativeEvent.locationX);
  let y = Math.round(nativeEvent.locationY);
  return {
    x: x,
    y: y,
  };
};

const TouchDetector = (props) => {
  const [backgroundColor, setBackgroundColor] = useState("#64ffda");

  const handleOnResponderGrant = function (evt) {
    setBackgroundColor("#a7ffeb");
    let pos = getTouchPosition(evt.nativeEvent);
    props.onTouchChanged(pos);
  };

  const handleOnResponderMove = function (evt) {
    let pos = getTouchPosition(evt.nativeEvent);
    props.onTouchChanged(pos);
  };

  const handleOnResponderRelease = function (evt) {
    setBackgroundColor("#64ffda");
    let pos = getTouchPosition(evt.nativeEvent);
    props.onTouchChanged(pos);
  };

  return (
    <View
      style={[styles.touchDetector, { backgroundColor: backgroundColor }]}
      onStartShouldSetResponder={handleOnStartShouldSetResponse.bind(this)}
      onMoveShouldSetResponder={handleOnMoveShouldSetResponse.bind(this)}
      onResponderGrant={handleOnResponderGrant.bind(this)}
      onResponderMove={handleOnResponderMove.bind(this)}
      onResponderRelease={handleOnResponderRelease.bind(this)}
    >
      <Text style={styles.touchDetectorText}>Interact with this area</Text>
    </View>
  );
};

const styles = StyleSheet.create({
  touchDetector: {
    width: "100%",
    height: 200,
    alignItems: "center",
    justifyContent: "center",
    marginBottom: 20,
    borderWidth: 2,
    borderColor: "#1de9b6",
  },

  touchDetectorText: {
    color: "#00695c",
  },
});

export default TouchDetector;
