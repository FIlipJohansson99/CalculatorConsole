using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsole
{
    public class MyCalculator
    {
        public static void Calculator()
        {
            bool exit = false;

            do
            {
                Menu();

            start:
                string op = Console.ReadLine();
                string inputA = "input";
                string inputB = "second input";
                string inputC = "third input";
                switch (op)
                {
                    case "0":
                    case "ext":
                        Console.Write("Exiting...\n");
                        exit = true;
                        break;
                    case "1":
                    case "add":
                        op = "+";
                        MathMethods.Addition(op, inputA, inputB);
                        break;
                    case "2":
                    case "sub":
                        op = "-";
                        MathMethods.Subtraction(op, inputA, inputB);
                        break;
                    case "3":
                    case "div":
                        op = "/";
                        MathMethods.Division(op, inputA, inputB);
                        break;
                    case "4":
                    case "mul":
                        op = "*";
                        MathMethods.Multiplication(op, inputA, inputB);
                        break;
                    case "5":
                    case "prc":
                        op = "/";
                        MathMethods.Percentage(op, inputA, inputB);
                        break;
                    case "6":
                    case "sqr":
                        inputA = "root";
                        MathMethods.SquareRoot(inputA);
                        break;
                    case "7":
                    case "tri":
                        op = "*";
                        inputA = "base";
                        inputB = "height";
                        MathMethods.AreaTriangle(op, inputA, inputC);
                        break;
                    case "8":
                    case "vol":
                        op = "*";
                        inputA = "base";
                        inputB = "height";
                        inputC = "depth";
                        MathMethods.Volume(op, inputA, inputB, inputC);
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        goto start;

                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (exit == false);
        }//Calculator
        public static double InputA(string inputA)
        {
            double numA;
            input:
            Console.WriteLine($"Enter your {inputA}, followed by Enter");
            string input = Console.ReadLine();
            while (!double.TryParse(input, out numA))
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The input can't be empty!");
                    goto input;
                }
                Console.WriteLine($"\"{input}\" Invalid input, enter a number using only numerical characters!");
                input = Console.ReadLine();
            }
            return numA;
        }//InputA
        public static double InputB(string op, double numA, string inputB)
        {
            Console.WriteLine($"Enter your {inputB}, followed by Enter");
            input:
            Console.Write($"{numA} {op} ");
            string input = Console.ReadLine();
            double numB;
            while (!double.TryParse(input, out numB))
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The input can't be empty!");
                    goto input;
                }
                Console.WriteLine($"\"{input}\" Invalid input, enter a number using only numerical characters!");
                input = Console.ReadLine();
            }
            return numB;
        }//InputB
        public static double InputC(string op, double numA, double numB, string inputC)
        {
            Console.WriteLine($"Enter your {inputC}, followed by Enter");
            input:
            Console.Write($"{numA} {op} {numB} {op} ");
            string input = Console.ReadLine();
            double numC;
            while (!double.TryParse(input, out numC))
            {
                if (String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("The input can't be empty!");
                    goto input;
                }
                Console.WriteLine($"\"{input}\" Invalid input, enter a number using only numerical characters!");
                input = Console.ReadLine();
            }
            return numC;
        }//InputC
        public static void Menu()
        {
            string title = "Console Calculator";
            Console.Clear();
            Console.WriteLine("\n-----" + title + "-----");
            Console.WriteLine("\n\t--Methods--");
            Console.WriteLine("\t0 OR ext - Exit");
            Console.WriteLine("\t1 OR add - Addition");
            Console.WriteLine("\t2 OR sub - Subtraction");
            Console.WriteLine("\t3 OR mul - Division");
            Console.WriteLine("\t4 OR div - Multiplication");
            Console.WriteLine("\t5 OR prc - Percentage");
            Console.WriteLine("\t6 OR sqr - Square Root");
            Console.WriteLine("\t7 OR tri - Area Triangle");
            Console.WriteLine("\t8 OR vol - Volume");
            Console.WriteLine("\nPlease select your preferred method...\n");
        }//Menu
    }//MyCalculator
    public class MathMethods
    {
        public static void Addition(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Addition Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} = {numA + numB}");
            return;
        }//Addition
        public static void Subtraction(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Subtraction Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} = {numA - numB}");
            return;
        }//Subtraction
        public static void Division(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Division Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} = {numA / numB}");
            return;
        }//Division
        public static void Multiplication(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Multiplication Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} = {numA * numB}");
            return;
        }//Multiplication
        public static void Percentage(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Percentage Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} * 100 = {(numA / numB) * 100}%");
            return;
        }//Percentage
        public static void SquareRoot(string inputA)
        {
            double numA;
            Console.WriteLine("Square Root Calculator");
            numA = MyCalculator.InputA(inputA);
            Console.WriteLine($"Result: Square Root of {numA} = {System.Math.Sqrt(numA)}");
            return;
        }//SquareRoot
        public static void AreaTriangle(string op, string inputA, string inputB)
        {
            double numA;
            double numB;
            Console.WriteLine("Triangle Area Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            Console.WriteLine($"Result: {numA} {op} {numB} / 2 = {((numB * numB) / 2)}");
            return;
        }//AreaTriangle
        public static void Volume(string op, string inputA, string inputB, string inputC)
        {
            double numA;
            double numB;
            double numC;
            Console.WriteLine("Volume Calculator");
            numA = MyCalculator.InputA(inputA);
            numB = MyCalculator.InputB(op, numA, inputB);
            numC = MyCalculator.InputC(op, numA, numB, inputC);
            Console.WriteLine($"Result: {numA} {op} {numB} {op} {numC} = {numB * numB * numC}");
            return;
        }//Volume
    }//MathMethods
}//CalculatorConsole

