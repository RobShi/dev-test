# -*- coding: utf-8 -*-
import unittest

from shi_mart import Item, ShiMart


class ShiMartTest(unittest.TestCase):
    def test_verify_item_behaviors(self):
        test_data = [
            (Item("Test", 10, 20), 9, 19),
            (Item("Regular Item", 5, 10), 4, 9),
            (Item("Aged Brie", 5, 10), 4, 11)
        ]
        
        x = [t[0] for t in test_data]
        x.append(Item("Some Item", 10, 20))
        x.append(Item("Aged Brie", 10, 20))
        y = Item("Canned Beans", 10, 20)
        x.append(y)
        
        app = ShiMart(x)
        app.update_quality()
        
        for i in range(len(test_data)):
            self.assertEqual(test_data[i][1], test_data[i][0].sell_in)
            self.assertEqual(test_data[i][2], test_data[i][0].quality)
        
        self.assertEqual(9, x[3].sell_in)
        self.assertEqual(19, x[3].quality)
        self.assertEqual(9, x[4].sell_in)
        self.assertEqual(21, x[4].quality)
        
        self.assertEqual(10, y.sell_in)
        self.assertEqual(20, y.quality)

        
if __name__ == '__main__':
    unittest.main()
