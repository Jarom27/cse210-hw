using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Jarom Mariscal", "CSE210 Programming with classes");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Juan Ignacio", "Fractions", "Section 17", "Problems 8-9");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Winters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}