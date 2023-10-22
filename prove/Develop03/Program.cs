using System;

class Program
{
    static void Main(string[] args)
    {
        string option = "";
        string[] scriptures = System.IO.File.ReadAllLines("scriptures.csv");
        Random selector = new Random();
        int choice = selector.Next(scriptures.Length);
        string[] data = scriptures[choice].Split("|");
        Scripture scripture = new Scripture(data[1], data[0]);
        do
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetRenderedText()} \n");
            Console.WriteLine("Please enter to continue or 'quit' to finish");
            option = Console.ReadLine();
            if (scripture.IsCompletlyHidden())
            {
                break;
            }
            scripture.HideWords();


        } while (option != "quit");
    }
}