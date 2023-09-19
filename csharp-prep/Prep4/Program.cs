using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        IList<int> numbers = new List<int>();
        int sum = 0, largestNumber = 0;
        float average = 0;
        while (true)
        {
            Console.Write("Enter a number: ");
            int enteredNumber = Convert.ToInt32(Console.ReadLine());
            if (enteredNumber == 0)
            {
                break;
            }
            numbers.Add(enteredNumber);
        }
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}