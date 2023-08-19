using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("Available Operations:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Square (^2)");
            Console.WriteLine("6. Square Root (sqrt)");
            Console.WriteLine("7. Power (^x)");
            Console.WriteLine("Enter the operation number: ");

            int choice = int.Parse(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the first number: ");
                    double addNum1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double addNum2 = double.Parse(Console.ReadLine());
                    result = CalculatorApp.Add(addNum1, addNum2);
                    break;

                case 2:
                    Console.Write("Enter the first number: ");
                    double subNum1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double subNum2 = double.Parse(Console.ReadLine());
                    result = CalculatorApp.Subtract(subNum1, subNum2);
                    break;

                case 3:
                    Console.Write("Enter the first number: ");
                    double mulNum1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    double mulNum2 = double.Parse(Console.ReadLine());
                    result = CalculatorApp.Multiply(mulNum1, mulNum2);
                    break;

                case 4:
                    Console.Write("Enter the dividend: ");
                    double divNum1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the divisor: ");
                    double divNum2 = double.Parse(Console.ReadLine());
                    try
                    {
                        result = CalculatorApp.Divide(divNum1, divNum2);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return;
                    }
                    break;

                case 5:
                    Console.Write("Enter a number: ");
                    double numToSquare = double.Parse(Console.ReadLine());
                    result = CalculatorApp.Square(numToSquare);
                    break;

                case 6:
                    Console.Write("Enter a number: ");
                    double numForSquareRoot = double.Parse(Console.ReadLine());
                    try
                    {
                        result = CalculatorApp.SquareRoot(numForSquareRoot);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return;
                    }
                    break;

                case 7:
                    Console.Write("Enter the base number: ");
                    double baseNum = double.Parse(Console.ReadLine());
                    Console.Write("Enter the exponent: ");
                    double exponent = double.Parse(Console.ReadLine());
                    result = CalculatorApp.Power(baseNum, exponent);
                    break;

                default:
                    Console.WriteLine("Invalid operation selected.");
                    return;
            }

            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }

    public class CalculatorApp
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public static double Square(double num)
        {
            return num * num;
        }

        public static double SquareRoot(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Cannot calculate square root of a negative number.");
            }
            return Math.Sqrt(num);
        }

        public static double Power(double num, double exponent)
        {
            return Math.Pow(num, exponent);
        }
    }
}
