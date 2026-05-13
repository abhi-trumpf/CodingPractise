using System;
using System.Linq;

namespace CodingPractise.CsharpCoding
{
	public class FindGreatestNumber
	{
		public static void Run()
		{
			int[] numbers = new int[3];

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write($"Enter number {i + 1}: ");

				// Inline check: If TryParse fails, we stay on the same number
				while (!int.TryParse(Console.ReadLine(), out numbers[i]))
				{
					Console.Write("Invalid input. Please enter a valid integer: ");
				}
			}
			// Optimization: Using System.Linq to find the Max instantly
			int greatest = numbers.Max();
			Console.WriteLine($"\nThe greatest number is: {greatest}");
		}
	}
}