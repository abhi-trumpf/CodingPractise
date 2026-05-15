using System;

namespace CodingPractise.CsharpCoding
{
	// 1. DEFINING the Logic Class
	public class SwapTwoNumbers
	{
		// This is the function DEFINITION
		public static void Run()
		{
			int a, b;
			//if input is correct -> true -> !true ->false -> the statement inside condition wont get executed and only the value will be assigned aka from string to integer ( conversion happens)

			if (!int.TryParse(Console.ReadLine(), out a)) // no need put out int a cuz 
				// int a and b are already being declared.
			{
				Console.WriteLine("Invalid input for a. Please enter a number.");
				return; // Stops the method safely
			}

			if (!int.TryParse(Console.ReadLine(), out b))
			{
				Console.WriteLine("Invalid input for a. Please enter a number.");
				return; // Stops the method safely
			}


			Console.WriteLine($"Before Swap: a = {a}, b = {b}");

			// The Swapping Logic (The "Temporary Variable" Method)
			int temp = a;
			a = b;
			b = temp;

			Console.WriteLine($"Swapped: a = {a}, b = {b}");
		}
	}
}

