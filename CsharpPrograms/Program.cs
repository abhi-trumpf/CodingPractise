
/*📁 CodingPractise(Main Folder)
│
└── 📁 CsharpCoding(Subfolder inside it)
*/

using System;
using CodingPractise.CsharpCoding; // <--- Add this!
                                   //using CodingPractise.CsharpCoding;
/*we are going to be accessing all the files ,functions and variables stored inside the sub folder*/
namespace CodingPractise
{
    public class Program
    {
        public static void Main(string[] args)
        /*we are only going to call the functions in the main which is a part of the bigger folder not 
          the sub folder*/
        {
            Console.WriteLine("Select a program to run:");
            Console.WriteLine("1. Swap 2 Numbers");
            Console.WriteLine("2. Greatest of Three Numbers");
            Console.WriteLine("3. Even or Odd Numbers");
            Console.WriteLine("4. Add Two Lists");
            Console.WriteLine("5. Frequency of Characters in a Word");
            Console.WriteLine("6. Integer to String");
            Console.WriteLine("7. Longest Prefix");
            Console.WriteLine("8. Palindrome");
            Console.WriteLine("9. Remove Duplicate");
            Console.WriteLine("10. String to Integer (Atoi)");
            Console.WriteLine("11. StrStr");
            Console.WriteLine("12. Valid Parentheses");
            Console.WriteLine("13. String Rotation or not");
            Console.WriteLine("14. Remove Vowels");
            Console.WriteLine("15. Constructors and Deconstructors");
            Console.WriteLine("16. Happy Number or not");

            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    SwapTwoNumbers.Run();
                    break;
                case "2":
                    FindGreatestNumber.Run();
                    break;
                case "3":
                    EvenOrOdd.Run();
                    break;
                case "4":
                    AddTwoLists.Run();
                    break;
                case "5":
                    FrequencyOfCharsInAWord.Run();
                    break;
                case "6":
                    IntegerToString.integerToString();
                    break;
                case "7":
                    LongestPrefix.longestPrefix();
                    break;
                case "8":
                    Palindrome.palindrome();
                    break;
                case "9":
                    RemoveDuplicate.removeDuplicate();
                    break;
                case "10":
                    StringToInteger.stringToInteger();
                    break;
                case "11":
                    IfWordExists.Run();
                    break;
                case "12":
                    ValidParenthesis.Run();
                    break;
                case "13":
                    Rotation.Run();
                    break;
                case "14":
                    RemoveVowels.Run();
                    return;
                case "15":
                    ConstructorOrDeconstructor.Run();
                    return;
                case "16":
                    HappyNumber.happyNumber();
                    return;

                default:
                    Console.WriteLine("Invalid selection. Please pick 1-16.");
                    break;
            }
        }
    }
}