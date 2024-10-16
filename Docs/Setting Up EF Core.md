# Setting Up Entity Framework Core with DbContext: A Beginner's Guide

## Introduction

This guide will walk you through the process of setting up Entity Framework Core (EF Core) in your C# project, focusing on creating and configuring a DbContext. We'll cover installation, basic setup, and provide a simple example.

## Step 1: Install Required Packages

First, you need to install the necessary NuGet packages. Open your terminal in the project directory and run:

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

```
## Step 2: Create your Models Models.cs 
```csharp 
using System.Collections.Generic;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; }
    public List<Review> Reviews { get; set; }
}

public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

public class Review
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int Rating { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}
```

# Step 3: Add connection string
- Create a text file to store connection string info
- Name it connectionString.txt
```text
Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
```


## Step 4: Create DbContext
- Create a file named BookContext.cs with the following content
```csharp 
using Microsoft.EntityFrameworkCore;
using System.IO;

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Review> Reviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = File.ReadAllText("connectionString.txt").Trim();
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Book)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BookId);
    }
}
```

# See 10/15 3rd and 4th video for explantion of refactoring project 


