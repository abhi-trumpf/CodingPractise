using System;

namespace CodingPractise.CsharpCoding
{
    public class IntegerToString
    {
        public static void integerToString()
        {
            int number = 12345;
            string result = intToString(number);
            Console.WriteLine($"\"{result}\""); // Output: "12345"
        }

        public static string intToString(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            if (num < 0)
            {
                return "-" + intToString(-num);
            }

            string result = "";
            while (num > 0)
            {
                int digit = num % 10; // get the last digit from the right
                result = (char)(digit + '0') + result; // convert digit to char and prepend to result
                num = num / 10; // remove the last digit
            }
            return result;
        }
    }
}