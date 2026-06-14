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
        int b = 0;

        if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
        int result = a / b;  // safe: zero-checked above

        Console.WriteLine("Result: " + result);
    }
}
