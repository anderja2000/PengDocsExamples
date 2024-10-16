## dotnet ef migrations add InitialCreate

A command used in Entity Framework Core to create the initial database migration.

- **Create Initial Migration**: Generates migration files based on current entity models
- **Version Control**: Establishes a starting point for tracking schema changes
- **Not Applied Yet**: Creates migration files; doesn't apply changes to the database

This command is typically run when setting up a new database using EF Core's Code-First approach, allowing developers to manage and version control their database schema.

```bash
dotnet ef migrations add InitialCreate
```

## dotnet ef database update

A command used in Entity Framework Core to apply pending migrations to the database.

- **Apply Migrations**: Executes all pending migrations on the target database
- **Update Schema**: Brings the database schema in sync with the current EF Core model
- **Create Database**: If the database doesn't exist, it creates one before applying migrations

This command is typically run after adding new migrations to update the database schema, ensuring it matches the current state of your application's data model.

```bash
dotnet ef database update
```