# Study Plan for C# and .NET Core

## Daily Goals
- [ ] Quick Review of Today's Goals
- [ ] YMCA Visit
- [ ] Return Home and Refresh
- [ ] Study C# Fundamentals
- [ ] Break/Relaxation
- [ ] Study .NET Core Concepts
- [ ] Errands (e.g., grocery shopping)
- [ ] Dinner Preparation and Eating
- [ ] Festivities/Fun Activity (hot chocolate bar prep)
- [ ] Optional Evening Study Session (Coding Challenges)
- [ ] Wind Down/Leisure Time Until Going to the Bar

---

## Study C# Fundamentals (1.5 - 2 hours)

### Checklist:
- **Review Basics:**
  - [ ] **Data Types:**
    - Understand the following data types:
      - `int`: Whole numbers (e.g., `int age = 30;`)
      - `string`: Text (e.g., `string name = "Alice";`)
      - `bool`: True/false values (e.g., `bool isStudent = true;`)
    - Resource: [C# Data Types](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/data-types)

  - [ ] **Variables and Constants:**
    - Declare variables and constants:
      ```csharp
      const double Pi = 3.14; // Constant
      int score = 100; // Variable
      ```
  
  - [ ] **Operators:**
    - Practice using operators:
      ```csharp
      int sum = 5 + 10; // Arithmetic
      bool isEqual = (5 == 5); // Comparison
      ```

- **Control Structures:**
  - [ ] **If-Else Statements:**
    - Write an if-else statement:
      ```csharp
      if (score >= 60)
      {
          Console.WriteLine("Passed");
      }
      else
      {
          Console.WriteLine("Failed");
      }
      ```

  - [ ] **Switch Statements:**
    - Use a switch statement:
      ```csharp
      switch (dayOfWeek)
      {
          case "Monday":
              Console.WriteLine("Start of the week!");
              break;
          case "Friday":
              Console.WriteLine("Almost weekend!");
              break;
          default:
              Console.WriteLine("Just another day.");
              break;
      }
      ```

  - [ ] **Loops:**
    - Implement loops:
      ```csharp
      for (int i = 0; i < 5; i++)
      {
          Console.WriteLine(i);
      }

      while (score < 100)
      {
          score++;
      }
      ```

- **Methods:**
  - [ ] Define and call methods:
    ```csharp
    void Greet(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
    
    Greet("Alice");
    ```

- **Arrays and Collections:**
  - [ ] Work with arrays:
    ```csharp
    int[] numbers = {1, 2, 3, 4, 5};
    Console.WriteLine(numbers); // Outputs: 1
    ```
  
  - [ ] Use lists:
    ```csharp
    List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
    names.Add("David");
    ```

- **Object-Oriented Programming (OOP):**
  - [ ] Understand classes and objects:
    ```csharp
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }
    }

    Person person = new Person { Name = "Alice", Age = 30 };
    person.Introduce();
    ```

- **Practice Coding Problems:**
  - Solve at least 3 problems on LeetCode related to arrays or strings:
    - Two Sum (Easy)
    - Valid Parentheses (Easy)
    - Remove Duplicates from Sorted Array (Easy)

