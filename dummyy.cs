// BuggyCalculator.cs
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
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
if (string.IsNullOrEmpty(password)) throw new InvalidOperationException("Missing DB_PASSWORD env variable");

        List<int> numbers = new List<int> { 10, 20, 30 };

        for (int i = 0; i <= numbers.Count; i++) // index out of range bug
        {
            Console.WriteLine(numbers[i]);
        }

        int a = 10;
        int b = 0;
        if (b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
if (b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
if (b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
if (b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
if (b == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
if (b == 0) { Console.WriteLine("Cannot divide by zero."); return; }
int result = a / b; // divide by zero bug  // safe — zero-check added above  // safe — zero-check added above  // safe — zero-check added above  // safe — zero-check added above  // safe — zero-check added above  // safe: zero-checked above

        Console.WriteLine("Result: " + result);
    }
}
