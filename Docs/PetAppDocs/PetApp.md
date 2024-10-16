
## Project Directory Structure 
```text 
PetApp/
│
├── Migrations/
│ ├── 20241016135537_Initial.cs
│ ├── 20241016135537_Initial.Designer.cs
│ └── PetContextModelSnapshot.cs
│
├── Pet.cs
├── Program.cs
└── PetContext.cs
```
# 1. Understanding the Pet Class
This document explains the structure and functionality of the `PetApp` project

*within The PetApp directory Pet.cs is made*

## Class Definition

```csharp
public class Pet
{
    public int PetId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Age { get; set; }

    public string PrintPet()
    {
        return $"Pet Name: {Name}, Type: {Type}, Age: {Age}";
    }
}
```
## Properties

The Pet class has four properties:

- **PetId**: An integer that serves as a unique identifier for each pet.
- **Name**: A string that stores the name of the pet.
- **Type**: A string that indicates the type or species of the pet (e.g., "Dog", "Cat", "Bird").
- **Age**: An integer representing the age of the pet.

All properties are public and have both getters and setters, allowing them to be read and modified from outside the class.

## Method

### PrintPet Method

The Pet class includes one method called PrintPet:

- This method returns a formatted string containing information about the pet.
- It uses string interpolation (indicated by the $ symbol) to create a human-readable description of the pet.
- The method includes the pet's name, type, and age in the returned string.
- Note that the PetId is not included in this string representation.

# 2. Understanding the PetContext class 

*within The PetApp directory PetContext.cs is made*


## <span style="color:pink">whole code file </span>(scroll down below to view breakdown)

```csharp
using Microsoft.EntityFrameworkCore; 

public class PetContext : DbContext{

    // Add constructor to avoid error of Unable to create a 'DbContext' of type ''
    public PetContext(DbContextOptions<PetContext> options) : base(options){}
    public DbSet<Pet> Pets {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder){



        // Seed initial data to the database
        modelBuilder.Entity<Pet>().HasData(

            new Pet { PetId = 1, Name = "Cooper", Type = "Dog", Age = 3},
            new Pet { PetId = 2, Name = "Marty", Type = "Cat", Age = 2},
            new Pet { PetId = 3, Name = "Ermak", Type = "Cat", Age = 13},
            new Pet { PetId = 4, Name = "Loki", Type = "Dog", Age = 7}

        );
    }

}

```
### Code Breakdown

1.  *<span style="color:yellow">Class Declaration with Inheritance</span>*

    ```csharp
    public class PetContext : DbContext
    ```


    - This line declares the PetContext class, which inherits from DbContext.
    - DbContext is a fundamental class in Entity Framework Core that:
        - Represents a session with the database
        - Allows you to query and save data
    - By inheriting from DbContext, PetContext gains all the database interaction capabilities provided by Entity Framework Core.

    <span style="color:red">**Explantion of Syntax**</span>

    -*<span style="color:orange">(DbContextOptions<PetContext> options)</span>*:
        - The parameter list. This constructor takes one parameter:
            - options of type DbContextOptions<PetContext>
    - *<span style="color:orange">DbContextOptions<PetContext></span>* is a generic type that contains configuration information specific to this PetContext.
    - *<span style="color:orange">: base(options)</span>:*
        - This is the constructor initializer.
        - It calls the constructor of the base class (DbContext) and passes the options parameter to it.
        - This ensures that the base DbContext is properly initialized with the provided options.

 2. *<span style="color:yellow">Constructor</span>*
    ```csharp
    public PetContext(DbContextOptions<PetContext> options) : base(options) { }
    ```
    - This constructor takes DbContextOptions<PetContext> as a parameter.
    - It passes these options to the base DbContext constructor.
    - This setup allows for dependency injection of database configuration, which is crucial for flexibility in configuring the database connection.

 3. *<span style="color:yellow">Dbset Property</span>*
    ```csharp 
    public DbSet<Pet> Pets { get; set; }
    ```

    - DbSet<Pet> represents the collection of all Pet entities in the context.
    - It allows you to query and save instances of the Pet class.
    - Entity Framework Core will use this to create a table named "Pets" in the database.

4. *<span style="color:yellow">OnModelCreating Method</span>*
    ```csharp
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    // Seed initial data to the database
    modelBuilder.Entity<Pet>().HasData(
        new Pet { PetId = 1, Name = "Cooper", Type = "Dog", Age = 3 },
        new Pet { PetId = 2, Name = "Marty", Type = "Cat", Age = 2 },
        new Pet { PetId = 3, Name = "Ermak", Type = "Cat", Age = 13 },
        new Pet { PetId = 4, Name = "Loki", Type = "Dog", Age = 7 }
         );
    }
    ```
    - This method is used to configure the model that EF Core creates in the database.
    - modelBuilder.Entity<Pet>().HasData() is used to seed initial data.
    - The HasData method allows you to provide initial data for the Pet table.
    - This data will be inserted into the database when migrations are applied.

5. **<span style="color:red">Key Points</span>**
    - Database Context: PetContext serves as the main point of interaction with the database for Pet-related operations.
    - Configuration Injection: The constructor allows for flexible database configuration through dependency injection.
    - Entity Set: The Pets property defines a queryable and modifiable set of Pet entities.
    - Data Seeding: The OnModelCreating method is overridden to provide initial data for the Pet table, ensuring the database starts with some predefined entries.
    - Model Configuration: While not shown in this example, OnModelCreating can also be used for more complex model configurations, such as defining relationships, indexes, or constraints.