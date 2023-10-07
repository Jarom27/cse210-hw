using System;
using System.Runtime.InteropServices;

class Program
{
    public static Journal _journal;
    static void Main(string[] args)
    {
        _journal = new Journal();
        int option = 0;
        do
        {
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());
            string filename = "";
            switch (option)
            {
                case 1:
                    _journal.InsertEntry();
                    break;

                case 2:
                    _journal.Display();
                    break;
                case 3:
                    filename = Console.ReadLine();
                    _journal.Load(filename);
                    break;
                case 4:
                    filename = Console.ReadLine();
                    _journal.Save(filename);
                    break;
                default:
                    break;
            }
        } while (option != 5);
    }
}