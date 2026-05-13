

using System;

namespace CodingPractise.CsharpCoding
{
    public class FindGreatestNumber // Renamed for clarity
    {


        public static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            Console.Write("Enter number 1: ");
            if (!int.TryParse(Console.ReadLine(), out int n1)) return;

            Console.Write("Enter number 2: ");
            if (!int.TryParse(Console.ReadLine(), out int n2)) return;

            Console.Write("Enter number 3: ");
            if (!int.TryParse(Console.ReadLine(), out int n3)) return;

            // Math.Max is a built-in C# tool that makes this very easy
            int greatest = Math.Max(n1, Math.Max(n2, n3));

            Console.WriteLine($"The greatest number is {greatest}");
        }
    }
    
}