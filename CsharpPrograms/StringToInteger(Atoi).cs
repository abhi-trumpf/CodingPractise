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

//digit = s[i] - '0'; convert from string to integer.



// For the string "aa2b", the final integer answer is 0.

// For the string "-44bt55", the final integer answer is -44.


/*
=========================================
TEST CASE 1: "-44bt55" (No space)
=========================================
Analyzing string...
Index 0: '-' -> isNegative = true, skipping via continue
Index 1: '4' -> ASCII 52 (Valid digit). result = 4
Index 2: '4' -> ASCII 52 (Valid digit). result = (4 * 10) + 4 = 44
Index 3: 'b' -> ASCII 98 (Out of range <48 or >57). Hitting break!
Loop terminated.
Applying negative sign...
Output: -44

=========================================
TEST CASE 2: "- 44bt55" (With space)  // will trigger break -0 gives 0.
=========================================
Analyzing string...
Index 0: '-' -> isNegative = true, skipping via continue
Index 1: ' ' -> ASCII 32 (Out of range: 32 is less than 48). Hitting break!
Loop terminated immediately.
Applying negative sign... result = 0 * -1
Output: 0


$ evaluate --statement "individual parts of the string have their own integer value that we obtain through ascii"

[STATUS]
100% CORRECT.

[VERIFICATION]
1. "Individual parts" = Each single character ('char') inside the string array.
2. "Own integer value" = The unique underlying ASCII code number assigned to that character.
3. "Obtain through ASCII" = Referencing the character index directly pushes its numerical code to the CPU processor.

$ echo "Perfect framing. Airtight logic."



$ clarify --concept-naming

[TERMINOLOGY]
1. "atoi" (ASCII to Integer): This is the industry-standard name for the *function's purpose*. It is a label for the end goal.
2. Your phrase: "Individual parts of the string have their own integer value that we obtain through ASCII": This is the *technical description of the mechanism*.

[CONCLUSION]
Both are correct in their own scope:
- "atoi" is the NAME of the tool.
- Your phrase is the EXPLANATION of how the tool functions.

[VERDICT]
Your definition is more descriptive and accurate regarding the internal mechanics.

$ evaluate --statement "basically return the number with their symbols till a letter appears"

[STATUS]
PARTIALLY CORRECT.

[REFINEMENT]
1. Your statement correctly identifies the "STOP" condition: the function terminates when it encounters a non-numeric character (like a letter).
2. EXCEPTION: It also stops on other characters, not just letters. 
   - Example: A space (' '), a symbol ('@'), or a punctuation mark ('.') will also trigger the 'break'.

[PRECISION]
"Return the number with its sign, processed character-by-character, terminating immediately upon encountering any non-digit character."

 */