let DefaultUiFactory = require("./Factories/DefaultUiFactory");
let FestivalUiFactory = require("./Factories/FestivalUiFactory");

let defaultUiFactory = new DefaultUiFactory();
let banner = defaultUiFactory.createBanner();
console.log(banner.themeColor);

let festivalUiFactory = new FestivalUiFactory();
banner = festivalUiFactory.createBanner();
console.log(banner.themeColor);
