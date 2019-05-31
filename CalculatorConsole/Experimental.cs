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

            var question = "";
            var op = "";
            double sum = 0;
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
            question = question.Replace(" ", $"{null}");
            string result = ($"{question} = {sum}");
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }



}
