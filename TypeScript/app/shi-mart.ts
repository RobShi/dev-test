export class Item {
  name: string;
  sellIn: number;
  quality: number;

  constructor(name: string, sellIn: number, quality: number) {
    this.name = name;
    this.sellIn = sellIn;
    this.quality = quality;
  }
}

export class ShiMart {
  items: Array<Item>;

  constructor(items: Array<Item> = []) {
    this.items = items;
  }

  updateQuality() {
    for (let i = 0; i < this.items.length; i++) 
    {
      if (this.items[i].name !== "Canned Beans") 
      {
        this.items[i].sellIn = this.items[i].sellIn - 1;
      }

      if (this.items[i].name === "Aged Brie")
      {
        if (this.items[i].quality < 50)
        {
          this.items[i].quality = this.items[i].quality + 1;
        }
      } else {
        if (this.items[i].quality > 0) 
        {
          if (this.items[i].name !== "Canned Beans") 
          {
            this.items[i].quality = this.items[i].quality - 1;
          }
        }
      }

      if (this.items[i].sellIn < 0) 
      {
        if (this.items[i].name === "Aged Brie") 
        {
          if (this.items[i].quality < 50) 
          {
            this.items[i].quality = this.items[i].quality + 1;
          }
        } else {
          if (this.items[i].quality > 0)
          {
            if (this.items[i].name !== "Canned Beans")
            {
              this.items[i].quality = this.items[i].quality - 1;
            }
          }
        }
      }
    }
  }
}