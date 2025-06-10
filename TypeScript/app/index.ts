import { Item, ShiMart } from './shi-mart';

const days = parseInt(process.argv[2]) || 31;

const items = [
  new Item("Bananas", 10, 20),
  new Item("Aged Brie", 2, 0),
  new Item("Eggs", 5, 7),
  new Item("Eggs", 12, 5),
  new Item("Canned Beans", 0, 80),
  new Item("Canned Beans", -1, 80),
  
  // This Baked good does not work properly yet!
  new Item("Baked Sourdough Bread", 3, 6)
];

const shiMart = new ShiMart(items);

for (let i = 0; i < days + 1; i++) {
  console.log(`-------- day ${i} --------`);
  console.log("name, sellIn, quality");
  for (const item of items) {
    console.log(`${item.name}, ${item.sellIn}, ${item.quality}`);
  }
  console.log("");
  shiMart.updateQuality();
}