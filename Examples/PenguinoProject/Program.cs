using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Data Types
        // Prompt: Declare an integer variable (e.g., age)
        int age; // Whole numbers
        age = 74;
        // Prompt: Declare a double variable (e.g., height)
        double height; // Double-precision floating-point numbers
        height = 11.6;
        // Prompt: Declare a float variable (e.g., weight)
        float weight; // Single-precision floating-point numbers
        weight = 420.69F;
        // Prompt: Declare a bool variable (e.g., isStudent)
        bool isStudent; // True/false values
        isStudent = true;
        // Prompt: Declare a char variable (e.g., initial)
        char initial; // A single Unicode character
        initial = 'k';
        // Prompt: Declare a string variable (e.g., name)
        string name; // A sequence of characters
        name = "penguino";
        // Prompt: Declare a decimal variable (e.g., price)
       
        // 2. Variables and Constants
        // Prompt: Declare a constant (e.g., Pi)
        const double Pi = 3.14; // Constant
        const double number = 3.14;

        // Prompt: Declare a variable (e.g., score)
        int score; // Variable
        score = 66;

        // 3. Operators
        // Prompt: Use arithmetic operators to calculate sum
        int sum; // Addition example
        sum = 2 + 4;
        // Prompt: Use comparison operators to check equality
        bool isEqual; // Comparison example
        isEqual = true;
        // 4. Control Structures
        // Prompt: Write an if statement to check score
        if (score >= 60)
        {
            Console.WriteLine("pass");
        }
        
        // Prompt: Write an if-else statement for pass/fail
        else
        {
            Console.WriteLine("fail");
        }

        // Prompt: Use a switch statement for dayOfWeek
        Console.WriteLine("Choose a day");
        string dayOfWeek = Console.ReadLine();
        switch (dayOfWeek)
        {
            case "monday":
               Console.WriteLine("Mondays fucking suck");
                break;
            case "friday":
                Console.WriteLine("Fucking finally!");
                break;
            default:
                Console.WriteLine("just another day in hell");
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