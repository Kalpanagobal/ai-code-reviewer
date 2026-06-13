using System;

class Program
{
    static void Main()
    {
        int[] values = { 5, 10, 15, 20 };

        // Bug 1: Off-by-one error
        for (int i = 0; i <= values.Length; i++)
        {
            Console.WriteLine(values[i]);
        }

        // Bug 2: Using an uninitialized variable
        int number;
        Console.WriteLine(number);

        // Bug 3: Incorrect condition
        string password = Environment.GetEnvironmentVariable("DB_PASSWORD"); // Fixed: use env var
        if (password.Length < 0)
        {
            Console.WriteLine("Invalid Password");
        }

        // Bug 4: Divide by zero
        int x = 100;
        int y = 0;
        Console.WriteLine(x / y);

        // Bug 5: Invalid cast
        object obj = "50";
        int n = (int)obj;

        Console.WriteLine(n);
    }
}
