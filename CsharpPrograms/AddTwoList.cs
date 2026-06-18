using System;

namespace CodingPractise
{
    // 1. The definition so Visual Studio understands what a ListNode is
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class AddTwoListsSimpler
    {
        public static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            // Step 1: Read the lists into strings of digits (built backwards to reverse them)
            string s1 = "", s2 = "";
            while (l1 != null) { s1 = l1.val + s1; l1 = l1.next; }
            while (l2 != null) { s2 = l2.val + s2; l2 = l2.next; }

            // Step 2: Parse them into normal numbers and add them together
            long sum = long.Parse(s1) + long.Parse(s2);

            // Step 3: Turn the sum into characters and flip them for LeetCode's reverse requirement
            char[] digits = sum.ToString().ToCharArray();
            Array.Reverse(digits);

            // Step 4: Rebuild the new linked list node by node
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            foreach (char d in digits)
            {
                current.next = new ListNode(d - '0'); // Converts character '7' to integer 7
                current = current.next;
            }

            return dummy.next;
        }

        // Just call AddTwoListsSimpler.Run() from your Program.cs Main file!
        public static void Run()
        {
            Console.WriteLine("--- Add Two Lists (Simplified String Version) ---");

            // Setting up: 2 -> 4 -> 3 (342) and 5 -> 6 -> 4 (465)
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

            Console.Write("List 1: ");
            PrintList(l1);
            Console.Write("List 2: ");
            PrintList(l2);

            ListNode? result = AddTwoNumbers(l1, l2);
            Console.Write("Result List: ");
            PrintList(result);
        }

        private static void PrintList(ListNode? head)
        {
            ListNode? temp = head;
            while (temp != null)
            {
                Console.Write(temp.val);
                if (temp.next != null) Console.Write(" -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}