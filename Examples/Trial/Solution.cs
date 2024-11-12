using System;
using System.Collections.Generic;

public class Solution
{
    public static void Main()
    {
        Console.Write("Enter a list: ");
        string[] inputArray = Console.ReadLine().Replace("[", "").Replace("]", "").Split(",");

        List<string> stringList = new List<string>();

        for (int i = 0; i < inputArray.Length; i++)
        {
            stringList.Add(inputArray[i].Trim());
        }

        List<string> sortedList = alphabetize(stringList);

        string result = "[";

        for (int i = 0; i < sortedList.Count; i++)
        {
            if (i == sortedList.Count - 1)
            {
                result += sortedList[i] + "]";
            }
            else
            {
                result += sortedList[i] + ",";
            }
        }

        Console.WriteLine(result);
    }

    public static List<string> alphabetize(List<string> stringList)
    {
        stringList.Sort();
        return stringList;
    }
}