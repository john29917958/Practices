import { StatusBar } from "expo-status-bar";
import {
  SafeAreaView,
  ScrollView,
  StyleSheet,
  TouchableHighlight,
  View,
} from "react-native";
import { Card, PaperProvider, Text, Button } from "react-native-paper";
import { useTheme } from "react-native-paper";
import { withTheme } from "react-native-paper";

export default withTheme(function App({ theme }) {
  const theTheme = useTheme(); // This is another way to get the theme object.

  return (
    <PaperProvider>
      <SafeAreaView style={styles.container}>
        <ScrollView
          style={{
            width: "100%",
            paddingTop: 10,
            paddingLeft: 15,
            paddingRight: 15,
          }}
        >
          <Text
            variant="titleLarge"
            style={{ color: theme.colors.primary, marginBottom: 20 }}
          >
            React Native Paper App
          </Text>
          <Card style={{ marginBottom: 20 }}>
            <Card.Title
              title="Your Option 1"
              subtitle="This is the description of option 1."
            />
            <Card.Content>
              <Text variant="bodyMedium" style={{ marginBottom: 20 }}>
                Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ab,
                consequatur?
              </Text>
            </Card.Content>
            <Card.Cover source={{ uri: "https://picsum.photos/600/400" }} />
            <Card.Actions>
              <Button onPress={() => {}}>Cancel</Button>
              <Button onPress={() => {}}>OK</Button>
            </Card.Actions>
          </Card>
          <Card style={{ marginBottom: 20 }}>
            <Card.Title
              title="Your Option 2"
              subtitle="This is the description of option 2."
            />
            <Card.Content>
              <Text variant="bodyMedium" style={{ marginBottom: 20 }}>
                Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ab,
                consequatur?
              </Text>
            </Card.Content>
            <Card.Actions>
              <Button onPress={() => {}}>Cancel</Button>
              <Button onPress={() => {}}>OK</Button>
            </Card.Actions>
          </Card>
          <Card style={{ marginBottom: 20 }}>
            <Card.Title
              title="Your Option 3"
              subtitle="This is the description of option 3."
            />
            <Card.Content>
              <Text variant="bodyMedium" style={{ marginBottom: 20 }}>
                Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ab,
                consequatur?
              </Text>
            </Card.Content>
            <Card.Actions>
              <Button onPress={() => {}}>Cancel</Button>
              <Button onPress={() => {}}>OK</Button>
            </Card.Actions>
          </Card>
          <Button
            mode="elevated"
            icon="check"
            onPress={() => {}}
            style={{ marginBottom: 20 }}
          >
            React Paper Button
          </Button>
        </ScrollView>
        <StatusBar style="auto" />
      </SafeAreaView>
    </PaperProvider>
  );
});

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
