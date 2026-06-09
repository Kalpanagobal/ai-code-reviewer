using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = null;

        Console.WriteLine("Enter count:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            numbers.Add(i);   // BUG 1: NullReferenceException
        }

        int sum = 0;

        for (int i = 0; i <= numbers.Count; i++)  // BUG 2: Off-by-one error
        {
            sum += numbers[i]; // BUG 3: IndexOutOfRangeException
        }

        Console.WriteLine("Sum is: " + sum);

        string text = "Hello";

        if (text = "Hello") // BUG 4: Assignment instead of comparison
        {
            Console.WriteLine("Matched");
        }

        try
        {
            int result = 10 / int.Parse("0"); // BUG 5: Divide by zero
            Console.WriteLine(result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error occurred");
            // BUG 6: Empty catch block hides real issue
        }

        Console.WriteLine("Program End");
    }
}
