using System;
using System.Collections.Generic;

namespace CodingPractise.CsharpCoding
{
    public class RemoveDuplicate()
    {
        public static void removeDuplicate()
        {
            String s = "sadnotsad";
            HashSet<char> noDuplicate = new HashSet<char>(s);
            string output = string.Join("", noDuplicate);
            Console.WriteLine(output);
        }
    }
}