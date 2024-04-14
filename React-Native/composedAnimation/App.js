import { StatusBar } from "expo-status-bar";
import { useEffect, useRef } from "react";
import { Animated, StyleSheet, Text, View } from "react-native";

const AppView = (props) => {
  const backgroundFadeAnim = useRef(new Animated.Value(0)).current;
  const yPosDiffAnim = useRef(new Animated.Value(0)).current;

  useEffect(() => {
    Animated.sequence([
      Animated.timing(backgroundFadeAnim, {
        toValue: 1,
        duration: 1000,
        useNativeDriver: true,
      }),
      Animated.parallel([
        Animated.timing(backgroundFadeAnim, {
          toValue: 0.5,
          duration: 500,
          useNativeDriver: true,
        }),
        Animated.timing(yPosDiffAnim, {
          toValue: 5,
          duration: 500,
          useNativeDriver: true,
        }),
      ]),
      Animated.parallel([
        Animated.timing(backgroundFadeAnim, {
          toValue: 1,
          duration: 500,
          useNativeDriver: true,
        }),
        Animated.timing(yPosDiffAnim, {
          toValue: 0,
          duration: 500,
          useNativeDriver: true,
        }),
      ]),
    ]).start();
  }, [backgroundFadeAnim]);

  return (
    <Animated.View
      style={{
        ...props.style,
        opacity: backgroundFadeAnim,
        transform: [
          {
            translateY: yPosDiffAnim,
          },
        ],
      }}
    >
      <Text
        style={{
          textAlign: "center",
          margin: 10,
          fontSize: 25,
        }}
      >
        Composed Animation
      </Text>
    </Animated.View>
  );
};

export default function App() {
  return (
    <View style={styles.container}>
      <AppView
        style={{
          alignItems: "center",
          justifyContent: "center",
          width: "90%",
          height: 50,
          backgroundColor: "#ef5350",
          borderColor: "#b71c1c",
        }}
      />
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
