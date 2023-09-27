let BasicFan = require("./Devices/BasicFan");
let AdvancedFan = require("./Devices/AdvancedFan");
let BasicRemote = require("./Remotes/BasicRemote");
let AdvancedRemote = require("./Remotes/AdvancedRemote");

let fan = new BasicFan();
let remote = new BasicRemote(fan);
remote.enable();
remote.disable();

fan = new AdvancedFan();
remote = new BasicRemote(fan);
remote.enable();
remote.disable();

fan = new BasicFan();
remote = new AdvancedRemote(fan);
remote.enable();
remote.disable();

fan = new AdvancedFan();
remote = new BasicRemote(fan);
remote.enable();
remote.disable();

remote = new AdvancedRemote(fan);
remote.enable();
remote.disable();
