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
        int[] marks = { 85, 90, 78, 92 };
        int total = 0;

        // Bug 1: Starts from index 1, skipping first element
        for (int i = 1; i < marks.Length; i++)
        {
            total += marks[i];
        }

        // Bug 2: Division by zero
        int divisor = 0;
        double result = total / divisor;

        // Bug 3: Incorrect string comparison
        string role = "Admin";
        if (role.ToLower() == "ADMIN")
        {
            Console.WriteLine("Administrator Access Granted");
        }

        // Bug 4: Format exception
        string ageText = "Twenty";
        if (!int.TryParse(ageText, out int age))
        { Console.WriteLine("Invalid input."); return; }

        // Bug 5: Null reference
        string email = null;
        Console.WriteLine(email.ToUpper());

        Console.WriteLine("Average Marks: " + result);
    }
}
