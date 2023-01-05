using System;
using Service.Interfaces;

namespace Service
{
	public class Calculator: ICalculator
	{
        public double Calculate(double number1, double number2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return number1 + number2;

                case "-":
                    return number1 - number2;

                case "/":
                    if (number2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't devide by zero");
                        Console.ResetColor();
                        return -1;
                    }

                    return number1 / number2;

                case "*":
                    return number1 * number2;

                default:
                    return -1;
            }
        }
    }
}