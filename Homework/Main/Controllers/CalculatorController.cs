using System;
using Service;
using Service.Interfaces;

namespace Main.Controllers
{
	public class CalculatorController
	{
		private readonly ICalculator _calculator;

		public CalculatorController()
		{
			_calculator = new Calculator();
		}

		public void Show()
		{
			Console.Write("Please enter first number: ");
			Number1: string num1RL = Console.ReadLine();
			double number1;
			bool checkNum1 = double.TryParse(num1RL, out number1);

			if (!checkNum1)
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write("Please do not enter anything other than numbers: ");
				Console.ResetColor();
				goto Number1;
			}

			Console.WriteLine("What do you want to do? Enter +, -, / or *:");
			Operator: string operation = Console.ReadLine();

			if (operation != "+" && operation != "*" && operation != "/" && operation != "-")
			{
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("Please, enter correct operator:");
				Console.ResetColor();
				goto Operator;
			}

            Console.Write("Enter second number: ");
			Number2: string num2RL = Console.ReadLine();
            double number2;
            bool checkNum2 = double.TryParse(num2RL, out number2);

            if (!checkNum2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please do not enter anything other than numbers: ");
                Console.ResetColor();
                goto Number2;
            }

			Console.WriteLine(_calculator.Calculate(number1, number2, operation));
        }
	}
}