using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string inputGrade = Console.ReadLine();

        int gradePercentage = int.Parse(inputGrade);
        string grade = "";

        int cociente = 0;
        if (gradePercentage >= 90)
        {
            grade = "A";
            cociente = gradePercentage % 90;
            if (cociente >= 7)
            {
                grade = grade + "+";
            }
            else
            {
                grade = grade + "-";
            }
        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            grade = "B";
            cociente = gradePercentage % 80;
            if (cociente >= 7)
            {
                grade = grade + "+";
            }
            else
            {
                grade = grade + "-";
            }
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            grade = "C";
            cociente = gradePercentage % 70;
            if (cociente >= 7)
            {
                grade = grade + "+";
            }
            else
            {
                grade = grade + "-";
            }
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            grade = "D";
            cociente = gradePercentage % 60;
            if (cociente >= 7)
            {
                grade = grade + "+";
            }
            else
            {
                grade = grade + "-";
            }
        }
        else
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is {grade}");
    }
}