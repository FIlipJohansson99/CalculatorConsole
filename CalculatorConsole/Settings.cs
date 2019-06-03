using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsole
{
    public class Settings
    {
        public static void SettingsMain()
        {
            string title = "Settings";
            bool exit = false;

            do
            {
                Console.Clear();
                string[] menuOptions = new string[9];
                menuOptions[0] = "Return";
                menuOptions[1] = "Foreground Color";
                menuOptions[2] = "Background Color";
                menuOptions[3] = "";
                menuOptions[4] = "";
                menuOptions[5] = "";
                menuOptions[6] = "";
                menuOptions[7] = "";
                menuOptions[8] = "";

                Program.Menu(menuOptions, title);

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        Foreground();
                        break;
                    case "2":
                        Background();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:
                        Program.TryAgain();
                        break;
                }//switch
            } while (!exit);
        }//SettingsMain
        public static void Foreground()
        {
            bool exit = false;
            string title = "Change Foreground";

            do
            {
                Console.Clear();
                string[] menuOptions = new string[9];
                menuOptions[0] = "Return";
                menuOptions[1] = "Red";
                menuOptions[2] = "Green";
                menuOptions[3] = "Blue";
                menuOptions[4] = "White";
                menuOptions[5] = "Black";
                menuOptions[6] = "";
                menuOptions[7] = "";
                menuOptions[8] = "Reset Color";

                Program.Menu(menuOptions, title);
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        if (Console.BackgroundColor == ConsoleColor.Red) {ColorError();}
                        else { Console.ForegroundColor = ConsoleColor.Red; }
                        break;
                    case "2":
                        if (Console.BackgroundColor == ConsoleColor.Green) {ColorError();}
                        else { Console.ForegroundColor = ConsoleColor.Green; }
                        break;
                    case "3":
                        if (Console.BackgroundColor == ConsoleColor.Blue) {ColorError();}
                        else { Console.ForegroundColor = ConsoleColor.Blue; }
                        break;
                    case "4":
                        if (Console.BackgroundColor == ConsoleColor.White) {ColorError();}
                        else { Console.ForegroundColor = ConsoleColor.White; }
                        break;
                    case "5":
                        if (Console.BackgroundColor == ConsoleColor.Black) {ColorError();}
                        else { Console.ForegroundColor = ConsoleColor.Black; }
                        break;
                    case "8":
                        Console.ResetColor();
                        break;
                    default:
                        Program.TryAgain();
                        break;
                }//switch
            } while (!exit);
        }//Foreground
        public static void Background()
        {
            bool exit = false;
            string title = "Change Background";

            do
            {
                Console.Clear();
                string[] menuOptions = new string[9];
                menuOptions[0] = "Return";
                menuOptions[1] = "Red";
                menuOptions[2] = "Green";
                menuOptions[3] = "Blue";
                menuOptions[4] = "White";
                menuOptions[5] = "Black";
                menuOptions[6] = "";
                menuOptions[7] = "";
                menuOptions[8] = "Reset Color";

                Program.Menu(menuOptions, title);
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        if (Console.ForegroundColor == ConsoleColor.Red) {ColorError();}
                        else {Console.BackgroundColor = ConsoleColor.Red;}

                        break;
                    case "2":
                        if (Console.ForegroundColor == ConsoleColor.Green) {ColorError();}
                        else { Console.BackgroundColor = ConsoleColor.Green; }                       
                        break;
                    case "3":
                        if (Console.ForegroundColor == ConsoleColor.Blue) {ColorError();}
                        else { Console.BackgroundColor = ConsoleColor.Blue; }
                        break;
                    case "4":
                        if (Console.ForegroundColor == ConsoleColor.White) {ColorError();}
                        else { Console.BackgroundColor = ConsoleColor.White; }
                        break;
                    case "5":
                        if (Console.ForegroundColor == ConsoleColor.Black) { ColorError(); }
                        else { Console.BackgroundColor = ConsoleColor.Black; }
                        break;
                    case "8":
                        Console.ResetColor();
                        break;
                    default:
                        Program.TryAgain();
                        break;
                }//switch
            } while (!exit);
        }//Background
        public static void ColorError()
        {
            {
                Console.WriteLine("You can't use the same background color as foreground color.");
                Program.PressAnyKey();
            }
        }//ColorError
    }//Settings
}//CalculatorConsole
