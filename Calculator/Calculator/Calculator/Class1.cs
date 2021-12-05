using System;

namespace Calculator
{
	public class CalcClass
	{
		public static void CalculatorMethod()
		{
			Console.WriteLine("Type first number");
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Type *,/,+,-");
			string z = Console.ReadLine();
			Console.WriteLine("Type second number");
			int y = Convert.ToInt32(Console.ReadLine());
			if (z == "+")
			{
				Console.WriteLine("Answer: {0}", x + y);
			}
			if (z == "-")
			{
				Console.WriteLine("Answer: {0}", x - y);
			}
			if (z == "*")
			{
				Console.WriteLine("Answer: {0}", x * y);
			}
			if (z == "/")
			{
				Console.WriteLine("Answer: {0}", x / y);
			}

		}

	}
}
