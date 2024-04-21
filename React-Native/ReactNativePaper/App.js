import { StatusBar } from "expo-status-bar";
import {
  SafeAreaView,
  ScrollView,
  StyleSheet,
  TouchableHighlight,
  View,
} from "react-native";
import {
  Card,
  PaperProvider,
  Text,
  Button,
  ActivityIndicator,
  MD3Colors,
  Appbar,
  useTheme,
  withTheme,
  FAB,
} from "react-native-paper";
import { useSafeAreaInsets } from "react-native-safe-area-context";

export default withTheme(function App({ theme }) {
  const theTheme = useTheme(); // This is another way to get the theme object.
  // const { bottom } = useSafeAreaInsets();
  const botomAppbarHeight = 80;

  return (
    <PaperProvider>
      <Appbar.Header mode="small">
        <Appbar.Content title="RNP" />
        <Appbar.Action icon="calendar" onPress={() => {}} />
        <Appbar.Action icon="magnify" onPress={() => {}} />
      </Appbar.Header>
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
            variant="headlineLarge"
            style={{ color: theme.colors.primary, marginBottom: 20 }}
          >
            React Native Paper App
          </Text>
          <Text variant="titleLarge" style={{ marginBottom: 20 }}>
            Cards
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
              <Button onPress={() => {}} icon="close">
                Cancel
              </Button>
              <Button onPress={() => {}} icon="check">
                OK
              </Button>
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
              <Button onPress={() => {}} icon="close">
                Cancel
              </Button>
              <Button onPress={() => {}} icon="check">
                OK
              </Button>
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
              <Button onPress={() => {}} icon="close">
                Cancel
              </Button>
              <Button onPress={() => {}} icon="check">
                OK
              </Button>
            </Card.Actions>
          </Card>
          <Text variant="titleLarge" style={{ marginBottom: 20 }}>
            Activity Indicators
          </Text>
          <ActivityIndicator
            animating={true}
            color={MD3Colors.theme}
            size="small"
            style={{ marginBottom: 20 }}
          />
          <ActivityIndicator
            animating={true}
            color={MD3Colors.theme}
            size="large"
            style={{ marginBottom: 20 }}
          />
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
      <Appbar
        style={[
          styles.bottom,
          {
            height: botomAppbarHeight,
          },
        ]}
        elevated={true}
        // safeAreaInsets={{ bottom }}
      >
        <Appbar.Action icon="archive" onPress={() => {}} />
        <Appbar.Action icon="email" onPress={() => {}} />
        <Appbar.Action icon="label" onPress={() => {}} />
        <Appbar.Action icon="delete" onPress={() => {}} />
        <FAB
          mode="flat"
          size="medium"
          icon="plus"
          onPress={() => {}}
          style={[
            styles.fab,
            {
              top: (botomAppbarHeight - 56) / 2,
            },
          ]}
        />
      </Appbar>
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

  fixedBottom: {
    position: "absolute",
    left: 0,
    right: 0,
    bottom: 0,
  },

  fab: {
    position: "absolute",
    right: 16,
  },
});
