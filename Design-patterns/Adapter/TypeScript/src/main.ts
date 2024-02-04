import { TextSerializer } from "./adapters/textSerializer";
import { JsonSerializer } from "./adapters/jsonSerializer";
import { Serializer } from "./adapters/serializer";

const userInfo = {
    name: "John Doe",
    age: 18,
    gender: "male"
};

let serializer: Serializer = new TextSerializer();
let userInfoString = serializer.serialize(userInfo);
console.log(userInfoString);
serializer = new JsonSerializer();
userInfoString = serializer.serialize(userInfo);
console.log(userInfoString);
