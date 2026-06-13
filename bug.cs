using System;
using System.Collections.Generic;

def your_function(param):
"""One-line summary.

Args:
param: Description.

Returns:
Description of return value.
"""
pass
{
    static void Main()
    {
        List<string> fruits = new List<string>();

        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Mango");

        // Bug 1: Index out of range
        Console.WriteLine(fruits[3]);

        // Bug 2: Wrong loop condition (infinite loop)
        int i = 0;
        while (i < fruits.Count)
        {
            Console.WriteLine(fruits[i]);
        }

        // Bug 3: Null reference
        string message = null;
        Console.WriteLine(message.Trim());

        // Bug 4: Overflow possibility
        byte num = 255;
        num++;

        Console.WriteLine("Number: " + num);
    }
}
