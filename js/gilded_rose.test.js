const chai = require('chai');
const sinon = require('sinon');
const expect = chai.expect;
const { Item, Shop } = require('./src/gilded_rose.js');


const items = [
  new Item("Bananas", 10, 20),
  new Item("Aged Brie", 2, 0),
  new Item("Eggs", 5, 7),
  new Item("Eggs", 12, 5),
  new Item("Canned Beans", 0, 80),
  new Item("Canned Beans", -1, 80),

  // This Baked good does not work properly yet!
  new Item("Baked Sourdough Bread", 3, 1),
];

describe('Gilded Rose', () => {

  describe('the updateQuality method', () => {

    it('updates quality', () => {
      console.log(items, 'items');
      const shop = new Shop(items);
      const shopsItems = shop.items;
      shop.updateQuality();

      expect(shopsItems[0].name).to.equal('Bananas');
      expect(shopsItems[0].sellIn).to.equal(9);
      expect(shopsItems[0].quality).to.equal(19);

      expect(shopsItems[1].quality).to.equal(1);
      expect(shopsItems[4].quality).to.equal(80);

      expect(shopsItems[6].quality).to.equal(0);
    })
  })
})


