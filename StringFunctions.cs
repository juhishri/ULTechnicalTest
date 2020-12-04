using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ULTechnicalTest
{
	public class StringFunctions
	{

		/// <summary>
		/// Method to return modified string as per the algorithm
		/// </summary>
		/// <param name="input"></param>
		/// <returns>string</returns>
		public static string NextLetter(string input)
		{
			var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
			string modifiedString;
			char[] arrayString = input.ToCharArray();
			if (!(input.Equals(null) && input.Contains(" ")))
			{

				for (int i = 0; i < arrayString.Length; i++)
				{
					if (Char.IsLetter(arrayString[i]))
					{
						arrayString[i] = (char)(arrayString[i] + 2);
						if (vowels.Contains(arrayString[i]))
						{
							arrayString[i] = Char.ToUpper(arrayString[i]);
						}
					}

				}

			}
			modifiedString = String.Join("", arrayString);
			return modifiedString;
		}


		/// <summary>
		/// Method to return bool true or false based on algorithm for a letter to be surrounded with '*'
		/// </summary>
		/// <param name="input"></param>
		/// <returns>bool</returns>
		public static bool StarredLetter(string input)
		{
			bool result = true;
			if (!(input.Equals(null) && input.Contains(" ")))
			{
				char[] arrayString = input.ToCharArray();
				for (int i = 0; i < arrayString.Length; i++)
				{
					if (Char.IsLetter(arrayString[i]))
					{
						if (i <= arrayString.Length)
						{
							if (arrayString[i + 1] == '*' && arrayString[i - 1] == '*')
								result = true;
							else
								result = false;
						}
						else break;
					}

				}
			}
			return result;
		}

		public static void Main(string[] args)
		{
			string nextLetterString = "£7eBm";
			string starredLetterString = "*a*%=3=*";
			Console.WriteLine("Output string is - " + NextLetter(nextLetterString));
			Console.WriteLine("String is -" + StarredLetter(starredLetterString));
		}
	}
}


