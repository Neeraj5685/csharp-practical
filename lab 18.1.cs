using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int result = 100 / num;   // May cause divide by zero
            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input! Please enter a number.");
        }
    }
}

