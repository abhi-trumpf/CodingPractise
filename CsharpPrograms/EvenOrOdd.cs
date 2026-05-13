using System;

namespace CodingPractise.CsharpCoding
{
	public class EvenOrOdd
	{
		public static void Run()
		{
			Console.Write("Enter your number: ");

			// HIGHLIGHT: Replace int.Parse with TryParse to prevent crashes
			if (!int.TryParse(Console.ReadLine(), out int n))
			{
				Console.WriteLine("Invalid input. Returning to menu...");
				return;
			}

			if (n % 2 == 0)
			{
				Console.WriteLine($"{n} is even");
			}
			else
			{
				Console.WriteLine($"{n} is odd");
			}
		}
	}
}
