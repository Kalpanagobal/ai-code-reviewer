using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;

        // Bug 1: Array index out of range
        for (int i = 0; i <= numbers.Length; i++)
        {
            sum += numbers[i];
        }

        // Bug 2: Integer division
        if (numbers == 0)
{
    Console.WriteLine("Error: Cannot divide by zero.");
    return;
}
double average = sum / numbers.Length;  // safe — zero-check added above

        // Bug 3: Assignment instead of comparison
        bool passed = false;
        if (passed = true)
        {
            Console.WriteLine("Passed");
        }

        // Bug 4: Null reference exception
        string name = null;
        Console.WriteLine(name.Length);

        Console.WriteLine("Average: " + average);
    }
}
