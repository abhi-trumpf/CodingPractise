using System;

namespace CodingPractise.CsharpCoding
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Select a program to run:");
			Console.WriteLine("1. Swap 2 numbers ");
			Console.WriteLine("2. Greatest of Three Numbers");
			Console.WriteLine("3. Even or Odd Numbers");
			string choice = Console.ReadLine() ?? "";

			Console.WriteLine(); // Adds a blank line for better spacing

			switch (choice)
			{
				case "1":
					SwapTwoNumbers.Run(); // till here I am doing for now
					break;

				case "2":
					FindGreatestNumber.Run();
					break;

				case "3":
					EvenOrOdd.Run();
					break;

				default:
					Console.WriteLine("Invalid selection. Please run the program again and pick 1-4.");
					break;
			}
		}
	}
}