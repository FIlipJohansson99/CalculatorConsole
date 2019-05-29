using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            MyCalculator.Calculator();

            bool on = true;
            bool selected = true;
            double numA = 0;
            double numB = 0;
            string title = "Console Calculator";
            if (on == true) ;
            /*{
                Console.Clear();
                Console.WriteLine("");
                numA = Math.InputA();
                numB = Math.InputB();
                Console.Clear();
                Console.Write($"\t{numA} ");
                Console.WriteLine("\n-----" + title + "-----");
                Console.WriteLine("\n\t--Methods--");
                Console.WriteLine("\t0 OR ext - Exit");
                Console.WriteLine("\t1 OR add - Addition");
                Console.WriteLine("\t2 OR sub - Subtraction");
                Console.WriteLine("\t3 OR mul - Multiplication");
                Console.WriteLine("\t4 OR div - Division");
                Console.WriteLine($"\t5 OR prc - Percent");
                Console.WriteLine("\nPlease select your preferred method...\n");

                do
                {
                    string op = Console.ReadLine();
                    string result = "";

                    switch (op)
                    {
                        case "0":
                            on = Exit();
                            break;

                        case "1":
                            op = "+";
                            Console.WriteLine("\tAddition");
                            result = Addition(numA, numB);
                            break;
                        case "2":
                            op = "-";
                            Console.WriteLine("Subtraction");
                            result = Subtraction(numA, numB);
                            break;
                        case "3":
                            op = "*";
                            Console.WriteLine("Multiplication");
                            result = Multiplication(numA, numB);
                            break;
                        case "4":
                            op = "/";
                            Console.WriteLine("Division");
                            result = Division(numA, numB);
                            break;
                        default:
                            Console.WriteLine("Invalid Selection");
                            selected = false;
                            break;
                    }
                    if (selected == true)
                    {
                        Console.WriteLine($"\tResult: {numA} {op} {numB} = {result}");
                    }
                } while (selected == false);
            }
            else { }
        } //Main   

        static bool Exit()
        {
            Console.WriteLine("Exiting...");
        return false;*/
        }      
    }
}
