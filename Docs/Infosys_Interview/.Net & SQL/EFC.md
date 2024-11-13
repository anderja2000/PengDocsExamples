

---

# Entity Framework Core Knowledge Base

---

### Must Have

---

#### Explain the purpose of an ORM and its role in Entity Framework Core.

An Object-Relational Mapper (ORM) helps developers interact with a database using object-oriented programming concepts rather than SQL (W). In Entity Framework Core, the ORM handles the translation between C# objects and database records (H), streamlining data access by reducing boilerplate code and enhancing productivity (Y).

---

#### Describe the DbContext class and its role in EF Core.

The `DbContext` class is the main point of interaction with the database (W). It manages the database connection, tracks changes, and provides `DbSet` properties for each entity to represent tables in the database (H). `DbContext` allows for querying and saving data, which is central to all database operations in EF Core (Y).

---

#### Differentiate between Data First and Code First approaches.

Data First and Code First are strategies to set up the database and model mappings in EF Core (W). With **Data First**, you generate models from an existing database, ideal for legacy databases (H). **Code First** allows you to create the schema from your model classes, useful for new projects where the database schema evolves with the application (Y).

---

#### What is migration, and how is it used in EF Core?

A migration in EF Core is a way to incrementally apply changes to the database schema as the model evolves (W). This is done by adding a migration, which generates SQL commands based on model changes, and then updating the database (H). Migrations ensure that the schema stays in sync with code (Y).

---

#### Describe the DbSet class and how it represents data in EF Core.

`DbSet` represents a table or collection of data within the context (W). Each `DbSet` property in `DbContext` is mapped to a database table, enabling CRUD operations through LINQ and EF Core methods (H). It provides a direct way to query, add, update, or delete data (Y).

---

### Should Have

---

#### Explain the OnModelCreating method and its significance.

The `OnModelCreating` method allows custom configuration of entity mappings using Fluent API (W). It's where you define relationships, specify table mappings, and enforce constraints (H). This configuration provides flexibility to meet advanced mapping requirements that data annotations alone can't handle (Y).

---

#### Describe how to perform CRUD operations using EF Core.

EF Core supports basic data operations directly through `DbContext` (W).

- **Add**: Adds a new entity to the database.

- **Update**: Modifies existing entity data.

- **Delete**: Removes an entity.

- **Query**: Retrieves data, often using LINQ.

Example: `context.Students.Add(new Student { Name = "John Doe" });` (H). These operations allow full interaction with the database using object-oriented syntax (Y).

---

#### How does EF Core manage relationships and perform "joins" between tables?

EF Core manages relationships using navigation properties and foreign key configurations (W). It allows joins through `Include` and `ThenInclude` methods to load related data efficiently (H). Joins help retrieve complex data hierarchies in a single query, reducing database roundtrips (Y).

---

#### What does the SaveChanges method do in EF Core?

`SaveChanges` commits any modifications made to the tracked entities in `DbContext` to the database (W). It determines the necessary SQL commands (insert, update, delete) based on entity state and executes them as a single transaction (H). This ensures data persistence and integrity (Y).

---

### Nice to Have

---

#### Explain eager and lazy loading in EF Core.

Eager loading fetches related data with the main query, while lazy loading retrieves related data only when accessed (W). Eager loading is achieved using `Include`, and lazy loading requires navigation properties to be `virtual` (H). Choosing the right loading strategy can significantly impact performance (Y).

---

#### How does seeding work in EF Core, and when would you use it?

Seeding populates the database with initial data when it is first created or after a migration (W). Data seeding can be configured in `OnModelCreating` to automatically populate tables (H). This approach is valuable for setting up default data or testing (Y).

---

#### Describe indexing in EF Core and its impact on performance.

Indexing in EF Core speeds up data retrieval by creating indexes on specified columns (W). You can configure indexes using the Fluent API with `HasIndex` (H). Indexes are particularly useful for frequently queried fields, helping improve performance in large datasets (Y).

---

### Advanced

---

#### How can you use stored procedures and raw SQL in EF Core?

EF Core allows the execution of stored procedures and raw SQL for complex or optimized queries (W). You can use `FromSqlRaw` or `ExecuteSqlRaw` for retrieval and non-query operations, respectively (H). This feature provides flexibility to leverage complex SQL operations when needed (Y).

---

#### How do transactions work in EF Core, and what are their benefits?

Transactions in EF Core ensure that multiple operations succeed or fail as a single unit (W). Transactions can be managed with `BeginTransaction` and `Commit`, and `SaveChanges` itself ensures a transaction for its batch operations (H). Transactions ensure data consistency and rollback capability (Y).
