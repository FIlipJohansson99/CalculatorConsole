using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            bool on = true;
            bool selected = true;
            string title = "Main Menu";
            Console.Clear();
            Console.WriteLine("");
            if (on == true)
            {
                Console.WriteLine("-----" + title + "-----\n");
                Console.WriteLine("\t0 - Exit");
                Console.WriteLine("\t1 - Calculator");
                Console.WriteLine("\t2 - Settings");

                Console.Write("\t- ");
                do
                {
                    string op = Console.ReadLine();
                    switch (op)
                    {
                        case "0":
                            Exit();
                            break;

                        case "1":
                            CalculatorMenu();
                            break;
                        case "2":
                            Settings();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection");
                            selected = false;
                            break;
                    }

                } while (selected == false);
            }
            else {}
        } //Main

        static bool Exit()
        {
            Console.WriteLine("Exiting...");
            return false;
        }

        static void CalculatorMenu()
        {
            bool selected = true;

            string title = "Console Calculator";
            Console.Clear();
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");
            Console.WriteLine("\t0 OR ext - Exit");
            Console.WriteLine("\t1 OR add - Addition");
            Console.WriteLine("\t2 OR sub - Subtraction");
            Console.WriteLine("\t3 OR mul - Multiplication");
            Console.WriteLine("\t4 OR div - Division");
            Console.WriteLine($"\t5 OR prc - Percent");
            Console.WriteLine("\nPlease select your preferred method...");
            Console.Write("\t- ");
            do
            {
                string op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        Exit();
                        break;

                    case "1":

                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        selected = false;
                        break;
                }

            } while (selected == false);


            return;
        }

        static void Settings()
        {

            bool selected = true;
            string title = "Settings";
            Console.Clear();
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");
            Console.WriteLine("\t0 - Exit");
            Console.WriteLine("\t1 - Foreground Color");
            Console.WriteLine("\t2 - Background Color");
            Console.WriteLine("\t3 - Return");
            Console.WriteLine("\nPlease select your preferred method...");
            Console.Write("\t- ");
            do
            {
                string op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        Exit();
                        break;
                    case "1":
                        Foreground();
                        break;
                    case "2":
                        Background();
                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        selected = false;
                        break;
                }

            } while (selected == false);
            return;
        }
        static void Foreground()
        {

            bool selected = true;
            string title = "Foreground";
            Console.Clear();
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");
            Console.WriteLine("\t0 - Exit");
            Console.WriteLine("\t1 - Foreground Color");
            Console.WriteLine("\t2 - Background Color");
            Console.WriteLine("\t3 - Return");
            Console.WriteLine("\nPlease select your preferred method...");
            Console.Write("\t- ");
            do
            {
                string op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        Exit();
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        selected = false;
                        break;
                }

            } while (selected == false);
            return;
        }
        static void Background()
        {

            bool selected = true;
            string title = "Background";
            Console.Clear();
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");
            Console.WriteLine("\t0 - Exit");
            Console.WriteLine("\t1 - Foreground Color");
            Console.WriteLine("\t2 - Background Color");
            Console.WriteLine("\t3 - Return");
            Console.WriteLine("\nPlease select your preferred method...");
            Console.Write("\t- ");
            do
            {
                string op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        Exit();
                        break;
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;

                    default:
                        Console.WriteLine("Invalid Selection");
                        selected = false;
                        break;
                }

            } while (selected == false);
            return;
        }
        static double VariableA()
                {
            Console.WriteLine("Enter your first input, followed by Enter");
            string inputA = Console.ReadLine();
            string inputB = Console.ReadLine();
            double numA;
            while (!double.TryParse(inputA, out numA))
            {
                Console.WriteLine("Invalid input, enter a number");
                inputA = Console.ReadLine();
            }
            return numA;
        }
        static double VariableB()
        {
            Console.WriteLine("Enter your second input, followed by Enter");
            string inputB = Console.ReadLine();
            double numB;
            while (!double.TryParse(inputB, out numB))
            {
                Console.WriteLine("Invalid input, enter a number");
                inputB = Console.ReadLine();
            }
            return numB;
        }
        /*
        static double Addition(double varA, double varB)
        { }
        static double Subtraction(double varA, double varB)
        { }
        static double Division(double varA, double varB)
        { }
        static double Multiplication(double varA, double varB)
        { }

        static string Problem(double varA, char op, double varB)
        {

        }
        
        */


    }

}
