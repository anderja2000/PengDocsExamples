using System; 
using System.Collections.Generic;

public class Test
{
    public static List<string> alphabetize(List<string> stringList)
    {
        // Sort the list using case-insensitive comparison
        stringList.Sort(StringComparer.OrdinalIgnoreCase);
        return stringList;
    }

    //DO NOT TOUCH THE CODE BELOW
    public static void Main()
    {
        string[] inputArray = Console.ReadLine().Replace("[", "").Replace("]", "").Split(",");
        List<string> stringList = new List<string>(inputArray);
        
        List<string> sortedList = alphabetize(stringList);
        
        string result = "[" + string.Join(",", sortedList) + "]";
        Console.WriteLine(result);
    }
}