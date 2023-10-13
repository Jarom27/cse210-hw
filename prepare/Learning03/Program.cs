using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction prove1 = new Fraction(1);
        Fraction prove2 = new Fraction(5);
        Fraction prove3 = new Fraction(3, 4);
        Fraction prove4 = new Fraction(1, 3);

        Console.WriteLine(prove1.GetFractionString());
        Console.WriteLine(prove1.GetDecimalValue());
        Console.WriteLine(prove2.GetFractionString());
        Console.WriteLine(prove2.GetDecimalValue());
        Console.WriteLine(prove3.GetFractionString());
        Console.WriteLine(prove3.GetDecimalValue());
        Console.WriteLine(prove4.GetFractionString());
        Console.WriteLine(prove4.GetDecimalValue());
    }
}