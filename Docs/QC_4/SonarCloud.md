#### What is static code analysis? What does it do for us?

Static code analysis examines source code for errors and adherence to coding standards without executing the program (W). It identifies issues early in development, allowing for proactive fixes (H). This improves code quality, maintainability, and security by enforcing best practices and preventing vulnerabilities (Y).

#### What is New Code definition?

The **New Code definition** in SonarCloud identifies which parts of the codebase are considered "new" or recently modified (W). It focuses quality checks on new changes to ensure they meet standards before merging (H). This approach helps maintain high-quality standards while progressively improving the overall codebase (Y).

#### What is Quality Gate?

A **Quality Gate** is a set of conditions that a project must meet to be considered ready for release (W). It includes metrics like code coverage and bug counts (H). Quality Gates enforce consistent quality standards, ensuring only code that meets these criteria is deployed, reducing defects and improving reliability (Y).

#### What are Maintenance issues?

**Maintenance issues** are problems that hinder code maintainability, such as complexity or duplicated code (W). While they may not cause immediate functional errors, they complicate future modifications (H). Addressing these issues ensures the code remains manageable and adaptable over time (Y).

#### What are Security issues?

**Security issues** are vulnerabilities in the code that could be exploited by attackers, such as SQL injection points or weak authentication (W). Identifying these issues early is crucial for protecting sensitive data and maintaining user trust in the application (H).

#### What are Reliability issues?

**Reliability issues** refer to aspects of the code that could lead to failures or crashes during execution (W). This includes unhandled exceptions or resource leaks that might not show up in testing but can cause operational failures (H). Resolving these issues enhances application stability and ensures consistent performance (Y).