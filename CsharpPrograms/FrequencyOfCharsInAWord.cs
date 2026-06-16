using System;
using System.Collections.Generic;

namespace CodingPractise.CsharpCoding
{
	public class FrequencyOfCharsInAWord
	{
		public static void Run() {
			string word = "hello";
		  Dictionary<char, int> charFrequency = new Dictionary<char, int>();
			foreach (char c in word)
			{
				if(charFrequency.ContainsKey(c))
				{
					charFrequency[c]++;
				}
				else
				{
					charFrequency[c] = 1;
				}
			}
			foreach(var kvp in charFrequency)
			{
				Console.WriteLine($"Character: {kvp.Key}, Frequency: {kvp.Value}");
			}
		}
	}
}