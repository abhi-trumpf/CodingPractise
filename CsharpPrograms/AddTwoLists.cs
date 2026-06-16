using System;

namespace CodingPractise.CsharpCoding
{
	// DEFINITION: There should be only ONE of these in your entire project
	public class ListNode
	{
		public int val;
		public ListNode? next; // 1. Can be null at the end of the list
		
		// 2. Added '?' here because the default value is null
		public ListNode(int val = 0, ListNode? next = null) 
		{
			this.val = val;
			this.next = next;
		}
	}

	public class AddTwoListsLogic
	{
		// 3. Added '?' because if both lists are empty, it could return null
		public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
		{
			ListNode dummy = new ListNode(0);
			ListNode current = dummy;
			int carry = 0;

			while (l1 != null || l2 != null || carry > 0)
			{
				int sum = carry;
				if (l1 != null) { sum += l1.val; l1 = l1.next; }
				if (l2 != null) { sum += l2.val; l2 = l2.next; }

				current.next = new ListNode(sum % 10);
				current = current.next;
				carry = sum / 10;
			}
			return dummy.next;
		}
	}

	public class AddTwoLists
	{
		public static void Run()
		{
			ListNode l1 = new ListNode(2, new ListNode(3, new ListNode(4)));
			ListNode l2 = new ListNode(3, new ListNode(4, new ListNode(5)));

			AddTwoListsLogic solver = new AddTwoListsLogic();
			ListNode? result = solver.AddTwoNumbers(l1, l2); // 4. Added '?' here too

			Console.Write("Result: ");
			while (result != null)
			{
				Console.Write(result.val + (result.next != null ? " -> " : ""));
				result = result.next;
			}
			Console.WriteLine();
		}
	}
}

//sum % 10--->Remainder--->  2(The digit we keep)
//sum / 10--->Whole Number--->  1(The carry for the next loop)