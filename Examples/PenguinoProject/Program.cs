using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Data Types
        // Prompt: Declare an integer variable (e.g., age)
        int age; // Whole numbers

        // Prompt: Declare a double variable (e.g., height)
        double height; // Double-precision floating-point numbers

        // Prompt: Declare a float variable (e.g., weight)
        float weight; // Single-precision floating-point numbers

        // Prompt: Declare a bool variable (e.g., isStudent)
        bool isStudent; // True/false values

        // Prompt: Declare a char variable (e.g., initial)
        char initial; // A single Unicode character

        // Prompt: Declare a string variable (e.g., name)
        string name; // A sequence of characters

        // Prompt: Declare a decimal variable (e.g., price)
        decimal price; // High-precision decimal values

        // 2. Variables and Constants
        // Prompt: Declare a constant (e.g., Pi)
        const double Pi = 3.14; // Constant

        // Prompt: Declare a variable (e.g., score)
        int score; // Variable

        // 3. Operators
        // Prompt: Use arithmetic operators to calculate sum
        int sum; // Addition example

        // Prompt: Use comparison operators to check equality
        bool isEqual; // Comparison example

        // 4. Control Structures
        // Prompt: Write an if statement to check score
        if (score >= 60)
        {
            // Output "Passed"
        }
        
        // Prompt: Write an if-else statement for pass/fail
        else
        {
            // Output "Failed"
        }

        // Prompt: Use a switch statement for dayOfWeek
        switch (dayOfWeek)
        {
            case "Monday":
                // Output "Start of the week!"
                break;
            case "Friday":
                // Output "Almost weekend!"
                break;
            default:
                // Output "Just another day."
                break;
        }

        // Loops
        // Prompt: Implement a for loop to iterate through numbers
        for (int i = 0; i < 5; i++)
        {
            // Output the index
        }

        // Prompt: Implement a while loop with count
        int count = 0;
        while (count < 5)
        {
            // Output count value
            count++;
        }

        // 5. Methods
        // Prompt: Define and call a method to greet someone
    }

    static void Greet(string name)
    {
       // Output greeting message
    }

    // 6. Arrays and Collections
    static void ArrayAndListExample()
    {
       // Prompt: Create an array of integers and output its elements
       int[] numbers = { }; 

       foreach (int number in numbers)
       {
           // Output each number
       }

       List<string> names = new List<string> { }; 
       names.Add("David"); 
       
       foreach (string n in names)
       {
           // Output each name
       }
    }

    // 7. Object-Oriented Programming (OOP)
    class Person
    {
       public string Name { get; set; }
       public int Age { get; set; }
       
       public void Introduce()
       {
           // Output introduction message
       }
    }
}