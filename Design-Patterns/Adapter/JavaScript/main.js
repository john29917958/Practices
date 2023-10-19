let JsonSerializer = require("./Adapters/JsonSerializer");
let TextSerializer = require("./Adapters/TextSerializer");

let userInfo = {
    name: "John Doe",
    age: 18,
    gender: "male"
};
let serializer = new JsonSerializer();
let serializedString = serializer.serialize(userInfo);
console.log(serializedString);
serializer = new TextSerializer();
serializedString = serializer.serialize(userInfo);
console.log(serializedString);
