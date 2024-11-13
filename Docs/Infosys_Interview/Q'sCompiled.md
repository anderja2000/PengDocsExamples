# C# Knowledge Base

---

### Compiled from Discord and Personal Mock Interview

---

#### What are the four pillars of OOP?

The four pillars of Object-Oriented Programming (OOP) are:

1. **Abstraction**: Hides the complexity and shows only the essential features of the object (W).
2. **Encapsulation**: Bundles the data and methods that operate on the data, restricting direct access to some of the object's components (H).
3. **Inheritance**: Allows a class to inherit properties and behaviors (methods) from another class, promoting code reuse (Y).
4. **Polymorphism**: Enables different objects to be treated as instances of the same class through a common interface, allowing one interface to be used for a general class of actions (W).

---

#### Which one of these, in your opinion, is the most important? Why?

Polymorphism is the most important pillar because it provides versatility (W). It allows multiple objects to be used interchangeably, making the code more flexible and reusable (H). With polymorphism, developers can write more generic code, improving maintainability and scalability (Y).

---

#### What is an expression?

An expression in C# is a syntactic construct that evaluates to a value (W). It is a combination of variables, constants, operators, and function calls that produce a result (H). For example, assigning a value to a variable or performing arithmetic operations is an expression (Y).

---

#### What are constructors?

Constructors are special methods used to initialize objects when they are created (W). They set the initial state of an object by taking in values for its fields or properties (H). Constructors allow for object instantiation with specific values, making objects flexible and reusable (Y).

---

#### What is an ORM?

An ORM (Object-Relational Mapping) is a programming technique used to interact with databases using objects, without writing raw SQL queries (W). It provides a higher-level abstraction for database operations, allowing developers to work in an object-oriented manner (H). ORMs also make it easier to switch databases without changing code (Y).

---

#### What is the DbContext Class?

The DbContext class represents a session with the database (W). It allows developers to query, add, update, and delete data from the database using C# objects (H). It is essential for interacting with the database and serves as a bridge between the application and the database (Y).

---

#### What is Asynchronous programming?

Asynchronous programming is a method that allows non-blocking operations, making it suitable for I/O-bound tasks like network requests or database operations (W). It uses the `async` keyword to define asynchronous methods and `await` to pause the execution until the task completes (H). This improves application responsiveness and efficiency (Y).

---

#### What is C#?

C# is a statically-typed, object-oriented programming language developed by Microsoft (W). It is part of the .NET framework and is commonly used for building Windows applications, web applications, and games (H). C# supports modern programming paradigms and is widely used in enterprise software development (Y).

---

#### Can you describe how you can use inheritance in a C# project?

Inheritance allows a class to inherit members (methods, properties, fields) from another class (W). In C#, you can create a base class and derive subclasses that inherit the base class's features, enhancing code reuse (H). This reduces code duplication and promotes better organization in larger projects (Y).

---

#### What is an exception in C#, and how do we handle exceptions?

An exception in C# is an error that occurs during the execution of a program (W). Exceptions can be handled using `try`, `catch`, and `finally` blocks (H). This allows the program to continue running gracefully, providing meaningful error messages and preventing crashes (Y).

---

#### What are the different loops that we can use in C#?

In C#, you can use several types of loops, including:

1. **for loop**: Executes a block of code a specified number of times (W).
2. **while loop**: Repeats a block of code while a condition is true (H).
3. **do-while loop**: Executes a block of code at least once, then continues while a condition is true (Y).
4. **foreach loop**: Iterates over elements in a collection, such as arrays or lists (Y).

---

#### What is a static method?

A static method is a method that belongs to the class rather than to any specific instance of the class (W). It can be called without creating an object of the class and is used for operations that do not require object state (H). Static methods are commonly used for utility functions (Y).

---

#### How do we instantiate an object in C#?

To instantiate an object in C#, you use the `new` keyword followed by the constructor of the class (W). For example: `MyClass obj = new MyClass();` (H). This creates an instance of the class, initializing its properties and methods for use (Y).

---

#### What is SQL?

SQL (Structured Query Language) is a language used for managing and manipulating relational databases (W). It allows users to query, insert, update, and delete data in a database (H). SQL is essential for working with databases and is widely used in backend development (Y).

---

#### What is a Primary Key?

A Primary Key is a unique identifier for a record in a database table (W). It ensures that each record can be uniquely identified and prevents duplicate entries (H). Primary Keys are essential for maintaining data integrity in relational databases (Y).

---

#### What is a Foreign Key, and how is it related to the Primary Key?

A Foreign Key is a field in a database table that creates a link between two tables (W). It points to the Primary Key in another table, establishing a relationship between the two tables (H). Foreign Keys ensure referential integrity, preventing inconsistent data between related tables (Y).

---

#### What are the different types of relationships possible between two tables?

In relational databases, the common types of relationships are:

1. **One-to-One**: One record in a table is related to one record in another table (W).
2. **One-to-Many**: One record in a table is related to multiple records in another table (H).
3. **Many-to-Many**: Multiple records in one table are related to multiple records in another table (Y).

---

#### Is there any special technology or library in C# to communicate with SQL databases?

Yes, in C#, technologies like ADO.NET, Entity Framework, and Dapper are commonly used to interact with SQL databases (W). These libraries abstract the database communication, allowing developers to query and manipulate data easily (H). Entity Framework is a popular ORM that simplifies database interactions (Y).

---

#### What is ASP.NET Core?

ASP.NET Core is a cross-platform, high-performance framework for building modern web applications and APIs (W). It is designed to work with .NET and supports both cloud-based and on-premises deployment (H). ASP.NET Core is widely used for building scalable, secure web applications (Y).

---

#### What is an API?

An API (Application Programming Interface) is a set of rules and protocols that allow different software systems to communicate with each other (W). APIs enable the integration of different services, applications, or components, allowing them to share data and functionality (H). APIs are fundamental for building modern web services and applications (Y).

---

#### What is HTTP?

HTTP (Hypertext Transfer Protocol) is a protocol used for transferring hypertext requests and information on the web (W). It is the foundation of data communication on the World Wide Web, enabling browsers and servers to communicate (H). HTTP defines how messages are formatted and transmitted (Y).

---
