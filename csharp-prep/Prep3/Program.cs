using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = new Random().Next(1, 100);
        int compareNumber = 0;
        int attemptsNumber = 0;
        do
        {
            Console.Write("What is your guess? ");
            compareNumber = Convert.ToInt32(Console.ReadLine());
            attemptsNumber++;
            if (compareNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (compareNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it after {attemptsNumber} attempts.");
                Console.Write("Do you want to play again?(y/n) ");
                string response = Console.ReadLine();
                if (response == "y")
                {
                    magicNumber = new Random().Next(1, 100);
                    attemptsNumber = 0;
                }
                else
                {
                    break;
                }
            }
        } while (compareNumber != magicNumber);

    }
}