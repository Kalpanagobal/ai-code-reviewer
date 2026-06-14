using System;

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
        int a = 10;
        int b = 5;

        Console.WriteLine(a - b); // Bug: should be addition
    }
}
