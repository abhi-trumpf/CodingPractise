using System;

namespace CodingPractise.CsharpCoding
{
    public class IntegerToString
    {
        public static void Run()
        {
            int number = 12345;
            string result = IntToString(number);
            Console.WriteLine(result); // Output: "12345"
        }

        public static string IntToString(int num)
        {
            if (num == 0)
            {
                return "0";
            }
            if (num < 0)
            {
                return "-" + IntToString(-num);
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
