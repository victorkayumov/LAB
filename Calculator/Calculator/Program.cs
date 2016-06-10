using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();
            switch (op)
            {
                case "+":
                   Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("wrong operator!!!");
                    break;

            }
            
                

            
        }
    }
}
