using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        EternalDemo eternalDemo = new EternalDemo();
        do
        {
            Console.WriteLine("Menu Options:\n 1.Create New Goal\n 2.List Goal\n 3.Save Goals\n 4.Load Goals\n 5.Record Event\n 6.Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    eternalDemo.CreateGoal();
                    break;
                case 2:
                    eternalDemo.DisplayGoals();
                    break;
                case 3:
                    eternalDemo.SaveGoals();
                    break;
                case 4:
                    eternalDemo.LoadGoals();
                    break;
                case 5:
                    eternalDemo.RecordEvent();
                    break;
                default:
                    break;
            }
        } while (option != 6);
    }
}