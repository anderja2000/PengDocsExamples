
---

# SQL Knowledge Base

---

### Must Have

---

#### Describe the relational database model and its components.

Relational databases organize data into tables, where rows represent records and columns represent attributes (W). Each table has a primary key that uniquely identifies each record, and relationships between tables are established using foreign keys (H). This model ensures data integrity and structured storage of data (Y).

---

#### Use SQL sublanguages (DDL, DML, DQL, DCL, TCL).

SQL is divided into sublanguages for different operations (W).  

- **DDL (Data Definition Language)**: Defines the structure of the database, e.g., `CREATE`, `ALTER`, `DROP`.  

- **DML (Data Manipulation Language)**: Manages data within the tables, e.g., `SELECT`, `INSERT`, `UPDATE`, `DELETE`.  

- **DQL (Data Query Language)**: Deals with data queries, primarily `SELECT`.  

- **DCL (Data Control Language)**: Manages permissions, e.g., `GRANT`, `REVOKE`.  

- **TCL (Transaction Control Language)**: Handles transactions, e.g., `COMMIT`, `ROLLBACK`. (H)  

SQL sublanguages are fundamental for effective interaction with the database (Y).

---

#### Create and use primary and foreign keys to establish relationships between tables.

Primary keys uniquely identify records within a table (W). Foreign keys ensure referential integrity by linking records between tables (H). For example, `CREATE TABLE Orders (OrderID INT PRIMARY KEY, CustomerID INT, FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID));` (Y).

---

#### Write SQL queries to perform basic operations: SELECT, INSERT, UPDATE, DELETE.

Basic SQL operations are essential for interacting with a database (W).  

- **SELECT**: Retrieves data from one or more tables.  

- **INSERT**: Adds new records to a table.  

- **UPDATE**: Modifies existing records.  

- **DELETE**: Removes records from a table.  

Example: `SELECT Name FROM Employees WHERE Department = 'HR';` (H). These operations form the core of SQL usage (Y).

---

#### Apply database normalization (1NF, 2NF, 3NF) to optimize database design.

Normalization ensures efficient database design by eliminating redundancy and dependency (W).  

- **1NF**: Eliminate repeating groups.  

- **2NF**: Eliminate partial dependency.  

- **3NF**: Eliminate transitive dependency.  

Example:  

- 1NF: `CREATE TABLE Employee (ID INT, Name VARCHAR(100), Department VARCHAR(50));`  

- 2NF: Normalize to avoid partial dependency between ID and Department (H).  

Normalization is vital for maintaining scalable and efficient databases (Y).

---

### Should Have

---

#### Use various types of joins (INNER, LEFT, RIGHT, FULL OUTER) to combine data from multiple tables.

Joins are used to retrieve related data from two or more tables based on a common column (W).  

- **INNER JOIN**: Returns only matching rows.  

- **LEFT JOIN**: Returns all rows from the left table and matched rows from the right table.  

- **RIGHT JOIN**: Returns all rows from the right table and matched rows from the left table.  

- **FULL OUTER JOIN**: Returns all rows when there is a match in one of the tables (H).  

Example: `SELECT E.Name, D.Name FROM Employees E INNER JOIN Departments D ON E.DeptID = D.ID;` (Y).

---

#### Create and use subqueries to perform nested queries.

Subqueries are used to perform a query within another query (W). For example, using a subquery in the `WHERE` clause:  

`SELECT Name FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees);` (H).  

Subqueries enable more complex filtering and conditional logic in SQL queries (Y).

---

#### Use aggregate functions (COUNT, SUM, AVG, MIN, MAX) to summarize data.

Aggregate functions allow summarization of data for analysis (W).  

- `COUNT`: Counts the number of rows.  

- `SUM`: Sums up the values in a column.  

- `AVG`: Calculates the average of a column.  

- `MIN` and `MAX`: Find the smallest and largest values, respectively.  

Example: `SELECT AVG(Salary) FROM Employees;` (H). These functions are critical for data analysis and reporting (Y).

---

#### Use GROUP BY and HAVING clauses to group and filter data.

The `GROUP BY` clause groups rows with common values, and the `HAVING` clause filters those groups (W).  

Example:  

`SELECT Department, COUNT(*) FROM Employees GROUP BY Department HAVING COUNT(*) > 5;` (H).  

This allows for efficient data aggregation and filtering based on grouped results (Y).

---

#### Understand transactions and ACID properties (Atomicity, Consistency, Isolation, Durability).

Transactions ensure that a series of operations are performed as a single unit (W). ACID properties guarantee reliable transaction handling:  

- **Atomicity**: All operations in the transaction must succeed or fail.  

- **Consistency**: The database is left in a consistent state after a transaction.  

- **Isolation**: Transactions are isolated from each other to prevent interference.  

- **Durability**: Once committed, changes are permanent.  

Example:  

`BEGIN TRANSACTION; UPDATE Employees SET Salary = Salary * 1.1 WHERE DeptID = 1; COMMIT;` (H).  

Understanding transactions is essential for managing data consistency and rollback during failures (Y).

---

### Nice to Have

---

#### Use set operations (UNION, INTERSECT, EXCEPT) to combine result sets from multiple queries.

Set operations allow for combining or excluding data from multiple queries (W).  

- **UNION**: Combines results from multiple SELECT statements, removing duplicates.  

- **INTERSECT**: Returns common rows from multiple SELECT statements.  

- **EXCEPT**: Returns rows from the first query that do not appear in the second query.  

Example: `SELECT Name FROM Employees UNION SELECT Name FROM Managers;` (H).  

Set operations are useful for comparing and manipulating data across multiple result sets (Y).

---

#### Use triggers to automate database operations.

Triggers automatically execute actions in response to database events such as `INSERT`, `UPDATE`, or `DELETE` (W).  

For example, creating an audit log entry every time an employee record is inserted:  

`CREATE TRIGGER trgAfterInsert ON Employees AFTER INSERT AS BEGIN INSERT INTO AuditLog VALUES (NEWID(), GETDATE()); END;` (H).  

Triggers are useful for enforcing business rules and automating repetitive tasks (Y).

---

#### Use stored procedures to encapsulate SQL logic.

Stored procedures are precompiled SQL statements that can be executed multiple times (W).  

Example:  

`CREATE PROCEDURE GetEmployeeDetails @EmployeeID INT AS BEGIN SELECT * FROM Employees WHERE ID = @EmployeeID; END;` (H).  

Stored procedures help modularize SQL logic, improving performance and reusability (Y).

---

#### Understand and implement indexing for performance optimization.

Indexes improve the speed of query execution by providing quick access to rows in a table (W).  

Example: `CREATE INDEX idx_employee_name ON Employees (Name);` (H).  

Indexes are essential for optimizing queries, especially in large databases (Y).

---
