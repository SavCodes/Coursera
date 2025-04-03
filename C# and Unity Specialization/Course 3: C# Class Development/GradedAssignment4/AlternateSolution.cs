using System;
using System.Collections.Generic;
using System.Threading.Channels;

// Solution works when ran locally but fails autograding on Coursera

namespace ProgrammingAssignment4
{
	// IMPORTANT: Only add code in the section
	// indicated below. The code I've provided
	// makes your solution work with the 
	// automated grader on Coursera

	/// <summary>
	/// Programming Assignment 4
	/// </summary>
	class Program
	{
		/// <summary>
		/// Programming Assignment 4
		/// </summary>
		/// <param name="args">command-line args</param>
		static void Main(string[] args)
		{
			// loop while there's more input
			string input = Console.ReadLine();
			while (input[0] != 'q')
			{
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed




                // Create the counting dictionary
                string keyString = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                Dictionary<char, int> letterFrequencyDictionary = new Dictionary<char, int>();
                foreach (char letter in keyString)
				{
					letterFrequencyDictionary.Add(letter, 0);
				}

				// Count letters in the input
				foreach (char letter in input)
				{
					char upperCaseChar = char.Parse(letter.ToString().ToUpper());

                    if (letterFrequencyDictionary.ContainsKey(upperCaseChar))
					{
						letterFrequencyDictionary[upperCaseChar]++;
					}
				}

				// Print the results
				foreach ( (char letter, int count) in letterFrequencyDictionary)
				{
					if (count != 0) Console.Write($"{letter}{count} ");
				}
				Console.WriteLine();


				// Don't add or modify any code below
				// this comment
				input = Console.ReadLine();
			}
		}

	
  }
}
