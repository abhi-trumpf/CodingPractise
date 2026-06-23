using System;

namespace CodingPractise.CsharpCoding
{
    public class Palindrome
    {
        public static void Run()
        {
            string s1 = "lol";
            string original = s1;
            string reversed = "";
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reversed += s1[i];
            }
            if (reversed == original)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
        }
    }
}
