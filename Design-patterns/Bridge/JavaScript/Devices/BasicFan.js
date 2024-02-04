let Fan = require("./Fan");

class BasicFan extends Fan {
    constructor() {
        super();
    }

    start() {
        console.log("Fan has been started.")
    }

    stop() {
        console.log("Fan has been stopped.")
    }
}

module.exports = BasicFan;
