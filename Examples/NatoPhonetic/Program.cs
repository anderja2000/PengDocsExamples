using System;
using System.Collections.Generic;

namespace NatoPhonetic
{
    /*
    Create a C# console application 
    that converts letters to their 
    NATO phonetic alphabet equivalents. Given:

    A: Alpha
    B: Bravo
    C: Charlie
    D: Delta
    E: Echo
    F: Foxtrot
    G: Golf

    Use ":(" for any input not A-G.
    Your task:

    Implement the main program structure.
    Create the required mappings for letters to their NATO phonetic alphabet words.
    Develop a method to convert the input string to NATO phonetic alphabet words.

    Handle user input and display the result.
    Example output:
    Enter a message: ABG DEF HIJ
    NATO Phonetic: Alpha Bravo Golf Delta Echo Foxtrot :( :( :(
    */

    class Program
    {
        /*
        A: Alpha
        B: Bravo
        C: Charlie
        D: Delta
        E: Echo
        F: Foxtrot
        G: Golf
        */

        static void Main(string[] args)
        {
            // Dictionary to store the conversions from 
            // English eg. A -> Alpha, B -> Bravo .... 
            Dictionary<char, string> Nato = new Dictionary<char, string>
            {
                {'A', "Alpha"}, {'B', "Bravo"}, {'C', "Charlie"},
                {'D', "Delta"}, {'E', "Echo"}, {'F', "Foxtrot"}, {'G', "Golf"}
            };

            Console.Write("Enter a message: ");
            string userInput = Console.ReadLine();
            string toNato = AlphabetToNato(userInput, Nato);
            Console.WriteLine("NATO Phonetic: " + toNato);
        }

        // Method that takes in a user message 
        // e.g. "ABC GE" -> ALPHA BRAVO CHARLIE GOLF ECHO  
        // associates each key with the corresponding value from the 
        // dictionary inputted Nato 
        static string AlphabetToNato(string message, Dictionary<char, string> Nato)
        {
            // Need to create a string to hold the converted text 
            string encodedText = "";

            // Loop through the message the user types in 
            // one char at a time 
            foreach (char letter in message.ToUpper())
            {
                // Compare letters in message to Dictionary Nato 
                // one at a time 
                if (Nato.ContainsKey(letter))
                {
                    // Add the corresponding value to the encodedText string 
                    encodedText += Nato[letter] + " ";
                }
                else if (letter == ' ')
                {
                    // Preserve spaces in the output
                    encodedText += " ";
                }
                else
                {
                    // Append ":(" for characters not found in the dictionary
                    encodedText += ":(" + " ";
                }
            }

            return encodedText; // Remove trailing space
        }
    }
}