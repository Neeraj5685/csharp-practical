using System;

// Interface 1
interface Exam
{
    bool Pass(int mark);
}

// Interface 2
interface Classify
{
    string Division(int average);
}

// Class implementing both interfaces
class Result : Exam, Classify
{
    // Pass method
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    // Division method
    public string Division(int average)
    {
        if (average >= 60)
            return "First Division";
        else if (average >= 50)
            return "Second Division";
        else if (average >= 40)
            return "Third Division";
        else
            return "Fail";
    }
}

// Main class
class Program
{
    static void Main(string[] args)
    {
        Result r = new Result();

        Console.Write("Enter Marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        // Pass check
        if (r.Pass(marks))
            Console.WriteLine("Result: Pass");
        else
            Console.WriteLine("Result: Fail");

        // Division check
        Console.WriteLine("Division: " + r.Division(avg));
    }
}