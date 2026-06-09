using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 0; i <= num; i++)   // BUG 1
        {
            numbers.Add(i);
        }

        int sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
        }

        Console.WriteLine("Sum is: " + sum);

        int result = Divide(sum, num);   // BUG 2
        Console.WriteLine("Result: " + result);
    }

    static int Divide(int a, int b)
    {
        return a / b;  // BUG 3 (possible divide by zero)
    }
}
