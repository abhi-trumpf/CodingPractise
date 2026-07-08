using System;

namespace CodingPractise.CsharpCoding
{
    public class StringToInteger
    {
        public static void stringToInteger()
        {
            string input = "- 44bt55";
            int z = stringToInt(input);
            Console.WriteLine(z);
        }

        public static int stringToInt(string s)
        {
            bool isNegative = s[0] == '-';
            /*
             * Step 1 (Compare): s[0] == '-' becomes true.
               Step 2 (Assign): bool isNegative = true;
             * 
             */
            int digit = 0;
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-')
                {
                    continue;
                }
                /*It literally translates whatever character
                 * is sitting at that position in the string into its raw ASCII number and asks
                    "Is this number less than 48? Or is it greater than 57?" 
                 */
                if (s[i] < '0' || s[i] > '9')
                {
                    break;
                }
                digit = s[i] - '0';
                result = result * 10 + digit;
            }

            if (isNegative)
            {
                result = -result;
            }
            return result;
        }
    }
}

