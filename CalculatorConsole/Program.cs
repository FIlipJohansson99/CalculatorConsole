using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console Calculator";
            string title = "Selector";
            bool exit = false;

            do
            {
                Console.Clear();
                string[] menuOptions = new string[9];
                menuOptions[0] = "Exit";
                menuOptions[1] = "Calculator";
                menuOptions[2] = "Experimental Build";
                menuOptions[3] = "";
                menuOptions[4] = "";
                menuOptions[5] = "";
                menuOptions[6] = "";
                menuOptions[7] = "";
                menuOptions[8] = "Settings";

                Menu(menuOptions, title);

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "0":
                        Console.WriteLine("Exiting...");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        exit = true;
                    break;
                    case "1":
                        MyCalculator.Calculator();
                        break;
                    case "2":
                        Experimental.ExperimentalMain();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection...");
                        Console.WriteLine("Press any key to try again...");
                        Console.ReadKey();
                        break;
                    case "8":
                        Settings.SettingsMain();
                        break;
                }//switch
            } while (exit == false);
        }//Main
        public static void Menu(string[] menuOptions, string title)
        {
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");

            for (int i = 0; i < menuOptions.Length; i++)
            {
                if (menuOptions[i].Length > 0)
                {
                    Console.WriteLine($"\t{i} - {menuOptions[i]}");
                }
            }
            Console.WriteLine("\nPlease select your preferred method...\n");
        }//Menu
    }//Program
}//CalculatorConsole
