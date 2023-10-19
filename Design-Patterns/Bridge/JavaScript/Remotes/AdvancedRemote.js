let Remote = require("./Remote");

class AdvancedRemote extends Remote {
    constructor(device) {
        super(device);
    }

    enable() {
        this.device.start();
        console.log("Remote shows cool light effect and start the device.");
    }

    disable() {
        this.device.stop();
        console.log("Remote shows cool light effect and stop the device.");
    }
}

module.exports = AdvancedRemote;
