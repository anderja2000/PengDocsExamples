# Querying with Entity Framework Core

Entity Framework Core uses LINQ (Language-Integrated Query) to query databases. This allows you to write strongly typed queries in C# or your preferred .NET language.

## How It Works

1. You write LINQ queries using your context and entity classes.
2. EF Core converts these queries to a database-agnostic representation.
3. The database provider translates this to specific SQL (or other query language).
4. Queries always execute against the database, even if entities already exist in the context.

## Common Query Tasks

### Loading All Data

```csharp
using (var context = new BloggingContext())
{
    var blogs = context.Blogs.ToList();
}
```

## Loading a single Entity 
```csharp
using (var context = new BloggingContext())
{
    var blog = context.Blogs
        .Single(b => b.BlogId == 1);
}
```
### Detailed Explanation:

- This query retrieves a single blog post with a specific ID.
- `Single()` is used when you expect exactly one result.
- `b => b.BlogId == 1` is a lambda expression that acts as a filter:
  - `b` represents each blog in the database
  - `b.BlogId == 1` checks if the blog's ID is 1
- If no blog with ID 1 exists, or if multiple blogs have ID 1 (which shouldn't happen with a proper primary key), an exception is thrown.
- For scenarios where the entity might not exist, consider using `SingleOrDefault()` instead.

# Filtering Data 
```csharp 
using (var context = new BloggingContext())
{
    var blogs = context.Blogs
        .Where(b => b.Url.Contains("dotnet"))
        .ToList();
}
```
### Detailed Explanation:

- This query filters blogs based on their URL content.
- `Where()` is used to specify filtering conditions.
- `b => b.Url.Contains("dotnet")` is a lambda expression that:
  - Checks each blog (`b`) in the database
  - Returns true if the blog's URL contains "dotnet" (case-sensitive)
- `Contains()` searches for a substring within the URL.
- `ToList()` executes the query and converts the results to a `List<T>`.
- The query returns all blogs with "dotnet" in their URL.
- This operation is translated to SQL and executed on the database server, not in memory.

### Key Points

- LINQ methods (`ToList()`, `Single()`, `Where()`) allow for powerful, readable queries.
- Queries are only executed when results are enumerated or materialized (e.g., by calling `ToList()`).
- EF Core uses parameterization to protect against SQL injection attacks.

### Further Reading

- [LINQ query expressions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/query-expression-basics)
- [How queries work in EF Core](https://docs.microsoft.com/en-us/ef/core/querying/how-query-works)
