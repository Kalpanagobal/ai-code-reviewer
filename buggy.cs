using System;

class Program
{
    static void Main()
    {
        int[] marks = { 85, 90, 70, 92 };
        int total = 0;

        // Bug 1 Fixed: Start from index 0 (not 1) to include all elements
        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        // Bug 2 Fixed: Check for division by zero before dividing
        int divisor = marks.Length;
        if (divisor == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return;
        }
        double result = total / divisor;
        Console.WriteLine("Average: " + result);

        // Bug 3 Fixed: Use == for string comparison (not ==, which was correct but ToLower fix)
        string role = "Admin";
        if (role.ToLower() == "admin")
        {
            Console.WriteLine("Administrator Access Granted");
        }

        // Bug 4 Fixed: Use int.TryParse instead of int.Parse to avoid FormatException
        string ageText = "Twenty";
        if (!int.TryParse(ageText, out int age))
        {
            Console.WriteLine("Error: Invalid age format. Please enter a numeric value.");
            age = 0;
        }
        Console.WriteLine("Age: " + age);

        // Bug 5 Fixed: Null check before accessing string methods
        string name = null;
        if (name != null)
        {
            Console.WriteLine(name.ToUpper());
        }
        else
        {
            Console.WriteLine("Error: Name is null. Please provide a valid name.");
        }
    }
}
