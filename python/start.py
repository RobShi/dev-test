# -*- coding: utf-8 -*-
from __future__ import print_function

from shi_mart import Item, ShiMart

if __name__ == "__main__":
    items = [
        Item(name="Bananas", sell_in=10, quality=20),
        Item(name="Aged Brie", sell_in=2, quality=0),
        Item(name="Eggs", sell_in=5, quality=7),
        Item(name="Eggs", sell_in=12, quality=5),
        Item(name="Canned Beans", sell_in=0, quality=80),
        Item(name="Canned Beans", sell_in=-1, quality=80),
        Item(name="Baked Sourdough Bread", sell_in=3, quality=6),
    ]

    days = 31
    import sys
    if len(sys.argv) > 1:
        days = int(sys.argv[1])
    
    shi_mart = ShiMart(items)
    
    for day in range(days):
        print("-------- day %s --------" % day)
        print("name, sellIn, quality")
        for item in items:
            print(item)
        print("")
        shi_mart.update_quality()
