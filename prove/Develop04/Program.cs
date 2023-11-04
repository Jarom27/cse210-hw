using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {

        string option;

        do
        {

            Console.WriteLine("Menu Options:\n1.Start breathing activity\n2.Start listening activity\n3.Start reflection activity\n4.Quit");
            option = Console.ReadLine();
            Activity activity = null;
            if (option == "1")
            {
                activity = new BreathingActivity();
            }
            else if (option == "2")
            {
                activity = new ListeningActivity();
            }
            else if (option == "3")
            {
                activity = new ReflectionActivity();
            }
            else
            {
                break;
            }
            activity.Run();

        } while (option != "4");
    }
}