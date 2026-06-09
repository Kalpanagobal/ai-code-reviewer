// BuggyCalculator.cs
using System;
using System.Collections.Generic;

class BuggyCalculator
{
    static void Main()
    {
        string password = "admin123"; // hardcoded secret

        List<int> numbers = new List<int> { 10, 20, 30 };

        for (int i = 0; i <= numbers.Count; i++) // index out of range bug
        {
            Console.WriteLine(numbers[i]);
        }

        int a = 10;
        int b = 0;
        int result = a / b; // divide by zero bug

        Console.WriteLine("Result: " + result);
    }
}
