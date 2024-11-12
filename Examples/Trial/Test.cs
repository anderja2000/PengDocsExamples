using System;

using System.Linq;

using System.Collections.Generic;

public class Test
{


	//DO NOT TOUCH THE CODE BELOW

	public static void Main()
	{

		string[] inputArray = Console.ReadLine().Replace("[", "").Replace("]", "").Split(",");

		string letter = Console.ReadLine();

		List<string> stringList = new List<string>();

		for (int i = 0; i < inputArray.Length; i++)
		{

			stringList.Add(inputArray[i]);

		}
c
		Console.WriteLine(checkForALetter(stringList, letter));

	}




	public static int checkForALetter(List<string> stringList, string letter)
	{

		//WRITE YOUR CODE HERE





		return stringList.Count(word => word.IndexOf(letter, StringComparison.OrdinalIgnoreCase) >= 0);

	}



}




