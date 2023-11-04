using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {

        string option;
        do
        {
            Activity activity;
            Console.WriteLine("Menu Options:\n1.Start breathing activity\n2.Start listening activity\n3.Start reflection activity\n4.Quit");
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.DisplayStartingMessage();
                    activity.Run();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.DisplayStartingMessage();
                    activity.Run();
                    break;
                case "3":
                    activity = new ListeningActivity();
                    activity.Run();
                    break;
                default:
                    break;
            }

        } while (option != "4");
    }
}