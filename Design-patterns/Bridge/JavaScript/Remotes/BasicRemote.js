let Remote = require("./Remote");

class BasicRemote extends Remote {
    constructor(device) {
        super(device);
    }

    enable() {
        this.device.start();
    }

    disable() {
        this.device.stop();
    }
}

module.exports = BasicRemote;
