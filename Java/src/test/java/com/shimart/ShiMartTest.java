package com.shimart;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.assertEquals;

import java.util.ArrayList;
import java.util.List;

class ShiMartTest {

    @Test
    void verifyItemBehaviors() {
        List<Object[]> testData = new ArrayList<>();
        testData.add(new Object[] { new Item("Test", 10, 20), 9, 19 });
        testData.add(new Object[] { new Item("Regular Item", 5, 10), 4, 9 });
        testData.add(new Object[] { new Item("Aged Brie", 5, 10), 4, 11 });
        
        List<Item> x = new ArrayList<>();
        for (Object[] data : testData) {
            x.add((Item) data[0]);
        }
        x.add(new Item("Some Item", 10, 20));
        x.add(new Item("Aged Brie", 10, 20));
        Item y = new Item("Canned Beans", 10, 20);
        x.add(y);
        
        ShiMart app = new ShiMart(x.toArray(new Item[0]));
        app.updateQuality();
        
        for (int i = 0; i < testData.size(); i++) {
            assertEquals((int) testData.get(i)[1], ((Item) testData.get(i)[0]).sellIn);
            assertEquals((int) testData.get(i)[2], ((Item) testData.get(i)[0]).quality);
        }
        
        assertEquals(9, x.get(3).sellIn);
        assertEquals(19, x.get(3).quality);
        assertEquals(9, x.get(4).sellIn);
        assertEquals(21, x.get(4).quality);
        
        assertEquals(10, y.sellIn);
        assertEquals(20, y.quality);
    }

}
