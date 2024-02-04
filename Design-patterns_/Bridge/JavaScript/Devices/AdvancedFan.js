let Fan = require("./Fan");

class AdvancedFan extends Fan {
    constructor() {
        super();
    }

    start() {
        console.log("Fan has been started with shinning cool light.");
    }

    stop() {
        console.log("Fan has been stopped with a cool light effect and sound.");
    }
}

module.exports = AdvancedFan;
