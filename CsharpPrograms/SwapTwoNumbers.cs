using System;

namespace CodingPractise.CsharpCoding
{
    // 1. DEFINING the Logic Class
    public class SwapTwoNumbers
    {
        // This is the function DEFINITION
        public static void Run()
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            // The Swapping Logic (The "Temporary Variable" Method)
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Swapped: a = {a}, b = {b}");
        }
    }

    // 2. THE ENTRY POINT
    class Program
    {
        public static void Main(string[] args)
        {
            // CALLING the Run function
            // Since it is static and in the same namespace, 
            // we call it using ClassName.MethodName()
            SwapTwoNumbers.Run();

            // Keep console window open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

