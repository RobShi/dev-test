const { Shop, Item } = require("./src/gilded_rose");

const items = [
  new Item("Bananas", 10, 20),
  new Item("Aged Brie", 2, 0),
  new Item("Eggs", 5, 7),
  new Item("Eggs", 12, 5),
  new Item("Canned Beans", 0, 80),
  new Item("Canned Beans", -1, 80),

  // This Baked good does not work properly yet!
  new Item("Baked Sourdough Bread", 3, 6),
];

const days = Number(process.argv[2]) || 2;
const gildedRose = new Shop(items);

for (let day = 0; day < days; day++) {
  console.log(`\n-------- day ${day} --------`);
  console.log("name, sellIn, quality");
  items.forEach(item => console.log(`${item.name}, ${item.sellIn}, ${item.quality}`));
  gildedRose.updateQuality();
}

module.export = {
  items,
};
