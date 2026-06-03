using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Alejandro García", "Division");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Lucía Fernández", "Algebra", "9.1", "12-24");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Diego Martínez", "World Literature", "Origins of Modern Poetry");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}