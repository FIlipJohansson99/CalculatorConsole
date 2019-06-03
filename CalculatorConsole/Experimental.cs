using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorConsole
{
    public class Experimental
    {
        public static void ExperimentalMain()
        {
            Console.WriteLine("Enter a question e.g. 10+10, only two variables may be entered");
            Console.WriteLine("Available Methods\n\"+\",\"-\",\"/\",\"*\"");

            var question = "";
            var op = "";
            double sum = 0;
            start:
            question = Console.ReadLine();

            if (question.Contains("+")) 
                {
                op = "+";
                var numbers = question.Split("+");
                sum = Convert.ToDouble(numbers[0]) + Convert.ToDouble(numbers[1]);
            }
            if (question.Contains("/"))
            {
                op = "/";
                var numbers = question.Split("/");
                sum = Convert.ToDouble(numbers[0]) / Convert.ToDouble(numbers[1]);
            }
            if (question.Contains("*"))
            {
                op = "*";
                var numbers = question.Split("*");
                sum = Convert.ToDouble(numbers[0]) * Convert.ToDouble(numbers[1]);
            }
            if (question.Contains("-"))
            {
                op = "-";
                var numbers = question.Split("-");
                sum = Convert.ToDouble(numbers[0]) - Convert.ToDouble(numbers[1]);
            }
            else if (sum == 0)
            {
                Console.WriteLine("I did not understand that question.");
                Console.WriteLine("Please format your question correctly e.g. \"{number} {method} {number}\"");
                goto start;
            }
            question = question.Replace(" ", $"{null}");
            string result = ($"{question} = {sum}");
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }



}
