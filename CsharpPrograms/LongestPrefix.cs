using System;

namespace CodingPractise.CsharpCoding
{
	public class LongestPrefix
	{
		public static void Run ()
		{
			string[] x = ["flower","flow","flight"];

			string prefix = x[0];

			for (int i = 1; i < x.Length; i++) //index through the words 1 by 1
			{//index chars on selected/specific word
				string CurrentWord = x[i];
				string TempPrefix = "";
				for (int j = 0; j < prefix.Length && j < CurrentWord.Length ; j++) 
				{
					if (CurrentWord[j] == prefix[j])
					{
						TempPrefix += CurrentWord[j];
					}
					else
					{
						break; // stop the loop if the characters do not match and go to next word
					}

				}
				prefix = TempPrefix; // update the prefix to the longest common prefix found so far
			}//from flower to flow -> prefix = flow -> from flow to flight -> prefix = fl 
			Console.WriteLine (prefix);
		}  // -> loop ends and fl is the longest common prefix
	}
}