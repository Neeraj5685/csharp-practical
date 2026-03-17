using System;

class Student
{
    int rollNo;
    string name;
    int marks;

   
    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }

    
    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }

   
    public string CalculateGrade()
    {
        if (marks >= 80)
            return "A";
        else if (marks >= 60)
            return "B";
        else if (marks >= 40)
            return "C";
        else
            return "Fail";
    }

   
    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + CalculateGrade());
    }
}

class Program
{
    static void Main()
    {
        
        Student s1 = new Student(101, "Neeraj", 75);
        s1.Display();

        Console.WriteLine();

        
        Student s2 = new Student();
        s2.Display();
    }
}