import { View, Text } from "react-native";

const DisplayArea = (props) => {
  return (
    <View
      style={{
        width: "100%",
        height: 100,
        alignItems: "center",
        justifyContent: "center",
        backgroundColor: "#fafafa",
        borderWidth: 1,
        borderColor: "#e0e0e0",
        borderRadius: 4
      }}
    >
      <Text>{props.message}</Text>
    </View>
  );
};

export default DisplayArea;
