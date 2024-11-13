# TypeScript Knowledge Base

---

### Must Have

---

#### What is TypeScript?

TypeScript is a superset of JavaScript that adds static typing to the language (W). It allows developers to catch errors at compile-time instead of runtime, improving code quality and maintainability (H). TypeScript is compiled (transpiled) into JavaScript, making it compatible with existing JavaScript libraries and frameworks (Y).

---

#### Is TypeScript strongly or weakly typed?

TypeScript is a strongly typed language (W). This means that variables, function parameters, and return values are associated with specific types, which are enforced at compile-time (H). TypeScript’s strong typing helps catch errors early in the development process, making it more reliable than JavaScript (Y).

---

#### Why should TypeScript be used?

TypeScript should be used because it provides static typing, which enhances code quality, improves developer productivity, and reduces errors (W). It also offers features like interfaces, decorators, and enhanced object-oriented programming (OOP) capabilities that are missing in JavaScript (H). Using TypeScript results in better tooling support, such as autocompletion and type inference (Y).

---

#### What datatypes are introduced in TypeScript which are not in JavaScript?

TypeScript introduces several new data types not found in JavaScript, including `enum`, `tuple`, and `any` (W). Enums provide a way to define a set of named constants, while tuples allow for arrays with fixed sizes and types for each element (H). The `any` type allows a variable to hold any type of value, bypassing TypeScript's strict typing rules when needed (Y).

---

#### What are union types?

Union types in TypeScript allow a variable to hold values of different types (W). They are declared by separating types with a pipe (`|`), such as `string | number` (H). Union types are useful when a variable can take on multiple types, enabling more flexible and dynamic code (Y).

---

#### What are type guards?

Type guards are TypeScript constructs that allow you to narrow down the type of a variable within a conditional block (W). They help TypeScript understand what type a variable is likely to be, based on certain checks (H). Examples include `typeof`, `instanceof`, and user-defined type guards (Y).

---

#### What features does TypeScript introduce apart from strong typing & new datatypes?

Apart from strong typing and new data types, TypeScript introduces features like interfaces, decorators, generics, and access modifiers (W). These features enhance object-oriented programming (OOP), provide better code organization, and improve reusability and type safety (H). TypeScript also includes tools for code refactoring, making it easier to maintain large codebases (Y).

---

#### What are decorators?

Decorators are special functions in TypeScript used to modify the behavior of classes, methods, or properties (W). They are a form of metaprogramming and are often used in frameworks like Angular to provide metadata or behavior to classes and their members (H). Decorators are a powerful tool for enhancing code organization and functionality (Y).

---

#### How about interfaces?

Interfaces in TypeScript are used to define the shape of an object, including its properties and methods (W). They enable a contract-based approach to coding, ensuring that classes or objects adhere to a specific structure (H). Interfaces are key to implementing OOP in TypeScript and promoting code modularity and reusability (Y).

---

#### How do you declare variables with types?

Variables in TypeScript are declared using the `let`, `const`, or `var` keywords, followed by a colon and the type (W). For example, `let age: number = 25;` (H). TypeScript infers the type when possible, but explicit type annotations are recommended for clarity and to avoid potential errors (Y).

---

#### What are two different ways to cast in TypeScript?

In TypeScript, you can cast a variable in two ways: 

1. Using the angle-bracket syntax: `<Type>variable`
2. Using the `as` keyword: `variable as Type` (W)

Both methods achieve the same result but have different syntax preferences depending on the context (H). Type casting is helpful when you need to inform TypeScript of a specific type that the variable should be treated as (Y).

---

#### How do you type generics in TypeScript?

Generics in TypeScript are typed using angle brackets, for example, `Array<T>` or `function<T>(value: T): T` (W). Generics allow you to write reusable code while maintaining type safety, as the type is determined at runtime rather than being explicitly defined (H). Generics are essential for functions and classes that can handle multiple types while preserving their specific type behavior (Y).

---

### Should Have

---

#### Compare/contrast TypeScript to JavaScript

TypeScript is a superset of JavaScript that adds optional static typing, interfaces, and other features (W). While JavaScript is dynamically typed and does not enforce type checking, TypeScript enables developers to catch type-related errors during development (H). TypeScript is transpiled into JavaScript, making it compatible with any JavaScript code, while offering more robust tooling and development experiences (Y).

---

#### Leverage strong, static typing throughout TypeScript with the proper syntax and types

In TypeScript, strong, static typing is leveraged by declaring variables, functions, and other structures with specific types (W). This enables type checking at compile time, which helps avoid runtime errors (H). Examples include declaring variables with types (`let age: number = 25;`) and using union types, interfaces, or custom types for better type safety (Y).

---

#### Use additional data types correctly depending on their use cases

TypeScript introduces several new data types such as `enum`, `tuple`, and `any`, which provide more flexible options for defining variables and structures (W). Enums are useful for representing a set of constants, tuples for fixed-length arrays with different types, and `any` for variables that can hold any type (H). Understanding when and how to use these types ensures better control over data structures and avoids runtime errors (Y).

---

#### Leverage easier implementations of OOP through the use of Interfaces and Access Modifiers

TypeScript’s support for interfaces and access modifiers (`public`, `private`, `protected`) makes it easier to implement object-oriented programming (OOP) patterns (W). Interfaces define the structure of objects, while access modifiers control the visibility and accessibility of class members (H). These features improve code organization, modularity, and maintainability (Y).

---

#### Understand the process of transpilation and its importance in web development

The process of transpilation in TypeScript involves converting TypeScript code into JavaScript code that can run in the browser (W). Since browsers only understand JavaScript, TypeScript code must be transpiled into standard JavaScript before deployment (H). Transpilation is essential for leveraging TypeScript’s features while ensuring compatibility with existing JavaScript code and browser environments (Y).

---

#### Know how to use TypeScript outside of Angular/React environments

TypeScript is not limited to Angular or React and can be used in any JavaScript-based environment, such as Node.js, Vue, or even vanilla JavaScript projects (W). Setting up TypeScript outside of these frameworks requires configuring a TypeScript project using a `tsconfig.json` file and compiling the TypeScript code into JavaScript (H). Using TypeScript across different platforms improves consistency and maintainability (Y).

---

#### Use enums within TypeScript code

Enums in TypeScript are used to define sets of named constants (W). They are ideal for situations where a variable can only hold specific predefined values, such as days of the week or status codes (H). Enums provide better type safety than using regular strings or numbers, and they can be used to improve code readability and reduce errors (Y).

---

#### Know what different TypeScript-unique features transpile to in JavaScript

TypeScript features like `enum`, interfaces, and access modifiers are not directly supported in JavaScript and are transpiled to more compatible JavaScript constructs (W). For example, `enum` is transpiled to an object, and interfaces are discarded since they don’t have a runtime representation (H). Understanding these transpilation results helps in knowing how TypeScript features behave in the final JavaScript code (Y).

---
# Node.js Knowledge Base

---

### Must Have

---

#### What is Node? Why is it used?

Node.js is a JavaScript runtime built on Chrome's V8 JavaScript engine (W). It allows developers to run JavaScript on the server side, enabling full-stack JavaScript development (H). Node.js is known for its non-blocking, event-driven architecture, making it highly efficient for building scalable applications like web servers, APIs, and real-time applications (Y).

---

#### What is npm?

npm (Node Package Manager) is a package manager for JavaScript and the default package manager for Node.js (W). It allows developers to install, share, and manage dependencies and packages required for their Node.js projects (H). npm helps automate the installation and management of third-party libraries, making development faster and easier (Y).

---

#### What is npx?

npx is a command-line tool that comes with npm (since version 5.2.0) and allows you to execute binaries from Node modules or even packages without installing them globally (W). It simplifies running scripts and commands without the need for installation (H). For example, you can use `npx create-react-app` to create a new React project without needing to install `create-react-app` globally (Y).

---

#### What is package.json?

`package.json` is a metadata file that is used to manage dependencies, scripts, and configurations for a Node.js project (W). It contains information such as the project's name, version, author, and license, as well as a list of dependencies and the scripts that are used for building, testing, and running the application (H). The `package.json` file is essential for managing and sharing Node.js applications (Y).

---

#### What is node_modules?

`node_modules` is a directory in a Node.js project where all the installed dependencies are stored (W). It is created when running `npm install` and contains all the packages that are specified in the `package.json` file (H). This directory allows Node.js to access third-party modules required by the project (Y). It's typically not committed to version control since it can be easily regenerated by running `npm install`.

---
