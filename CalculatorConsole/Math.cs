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
            do { 
            start:
            string op = Console.ReadLine();
                switch (op)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        MathMethods.Addition();
                        break;
                    case "2":
                        MathMethods.Subtraction();
                        break;
                    case "3":
                        MathMethods.Division();
                        break;
                    case "4":
                        MathMethods.Multiplication();
                        break;
                    case "5":
                        MathMethods.Percentage();
                        break;
                    case "6":
                        MathMethods.SquareRoot();
                        break;
                    case "7":
                        MathMethods.AreaTriangle();
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        goto start;

                }
            } while (exit == false);
        }
        public static double InputA()
        {
            double numA;
        input:
            Console.WriteLine("Enter your input, followed by Enter");
            string input = Console.ReadLine();
            while (!double.TryParse(input, out numA))
            {
                if (input == "")
                {
                    Console.WriteLine("The input can't be empty!");
                    goto input;
                }
                Console.WriteLine($"\"{input}\" Invalid input, enter a number using only numerical characters!");
                input = Console.ReadLine();
            }
            return numA;
        }
        public static double InputB()
        {

            Console.WriteLine("Enter your second input, followed by Enter");
        input:
            string input = Console.ReadLine();
            double numB;
            while (!double.TryParse(input, out numB))
            {
                if (input == "")
                {
                    Console.WriteLine("The input can't be empty!");
                    goto input;
                }
                Console.WriteLine($"\"{input}\" Invalid input, enter a number using only numerical characters!");
                input = Console.ReadLine();
            }
            return numB;
        }



    }
    public class MathMethods
    {
        public static void Addition()
        {
            double numA;
            double numB;
            Console.WriteLine("Multiplication Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} + {numB} = {(numB + numB)}");
            return;
        }
        public static void Subtraction()
        {
            double numA;
            double numB;
            Console.WriteLine("Subtraction Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} - {numB} = {(numB - numB)}");
            return;
        }
        public static void Division()
        {
            double numA;
            double numB;
            Console.WriteLine("Division Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} / {numB} = {(numB / numB)}");
            return;
        }
        public static void Multiplication()
        {
            double numA;
            double numB;
            Console.WriteLine("Multiplication Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} * {numB} = {(numB * numB)}");
            return;
        }
        public static void Percentage()
        {
            double numA;
            double numB;
            Console.WriteLine("Percentage Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} / {numB} * 100 = {(numB / numB) * 100}%");
            return;
        }
        public static void SquareRoot()
        {
            double numA;
            Console.WriteLine("Square Root Calculator");
            numA = MyCalculator.InputA();
            Console.WriteLine ($"Result: √{numA} = {System.Math.Sqrt(numA)}");
            return;
        }
        public static void AreaTriangle()
        {
            double numA;
            double numB;
            Console.WriteLine("Triangle Area Calculator");
            numA = MyCalculator.InputA();
            numB = MyCalculator.InputB();
            Console.WriteLine($"Result: {numA} * {numB} / 2 = {((numB*numB) / 2)}");
            return;
        }

    }
}

