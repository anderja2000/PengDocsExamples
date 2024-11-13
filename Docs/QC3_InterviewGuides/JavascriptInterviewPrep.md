# JavaScript Knowledge Base

---

### Must Have

---

#### What is JavaScript?

JavaScript is a high-level, interpreted programming language used primarily for creating interactive and dynamic content in web pages (W). It is an essential language for web development, as it runs in the browser and allows developers to manipulate the DOM, handle events, and make asynchronous requests (H). JavaScript is also used on the server-side, especially with Node.js, and is a core language in full-stack development (Y).

---

#### What is type coercion in JavaScript?

Type coercion is the process of automatically or implicitly converting one data type to another (W). This happens in JavaScript when operations or expressions involve incompatible data types, such as adding a number and a string (H). JavaScript handles type coercion behind the scenes, but it can sometimes lead to unexpected results, so it's important to understand how and when it occurs (Y).

---

#### What are truthy and falsy values in JavaScript?

Truthy values are values that are considered true when evaluated in a boolean context (W). Examples include non-zero numbers, non-empty strings, and objects (H). Falsy values are values that are considered false in a boolean context, such as `false`, `0`, `""`, `null`, `undefined`, and `NaN` (H). Understanding these helps avoid bugs related to conditionals (Y).

---

#### What are the different variable scopes in JavaScript?

JavaScript has three types of variable scopes: global, function, and block (W). Variables declared outside of functions are in the global scope, while those declared inside functions are in function scope (H). With ES6, block-scoped variables can be declared using `let` or `const` (Y). Scoping rules are important for managing variable accessibility and avoiding issues like variable shadowing (Y).

---

#### What are the different data types in JavaScript?

JavaScript has several data types: primitive types (like `string`, `number`, `boolean`, `undefined`, `null`, and `symbol`) and non-primitive types like `object` (W). Primitive types are immutable, while objects are mutable and can hold multiple values (H). Understanding these types helps prevent errors when manipulating data (Y).

---

#### How do you create variables in JavaScript?

Variables in JavaScript can be created using `var`, `let`, or `const` (W). `var` is function-scoped, while `let` and `const` are block-scoped, with `const` being used for values that cannot be reassigned (H). Choosing the right declaration helps manage scope and immutability (Y).

---

#### How do you create objects in JavaScript?

Objects in JavaScript are created using object literals, where key-value pairs define the properties of the object (W). You can also create objects using the `new Object()` syntax (H). Objects are fundamental for organizing data and enabling object-oriented programming (Y).

---

#### What is the DOM?

The Document Object Model (DOM) is a programming interface for web documents (W). It represents the structure of an HTML document as a tree of objects, where each node corresponds to part of the page (H). JavaScript can interact with the DOM to modify content, structure, and style dynamically (Y).

---

#### How do you query the DOM for elements?

You can query the DOM using methods like `document.getElementById()`, `document.querySelector()`, and `document.querySelectorAll()` (W). These methods return references to DOM elements, allowing you to manipulate or interact with them (H). DOM manipulation is a core feature for dynamic web pages (Y).

---

#### What are event listeners in JavaScript?

Event listeners are functions that wait for specific events to occur (W). Events like `click`, `keydown`, or `submit` can trigger a listener function when the event occurs on a DOM element (H). Event listeners are essential for interactivity in web applications (Y).

---

#### What are bubbling and capturing in JavaScript?

Bubbling and capturing refer to the phases in event propagation (W). In bubbling, the event starts at the target element and propagates up to the root (H). In capturing, the event starts from the root and travels down to the target element (H). Understanding these phases is important for controlling event handling behavior (Y).

---

#### What is the Fetch API?

The Fetch API allows you to send network requests to a server and handle responses asynchronously (W). It returns a promise, which resolves to a `Response` object representing the response to the request (H). The Fetch API is commonly used for making AJAX requests and fetching data from APIs (Y).

---

#### What is function and variable hoisting?

Hoisting is a JavaScript mechanism where variables and functions are moved to the top of their scope before code execution (W). Variables declared with `var` are hoisted, but their value assignment is not (H). Functions declared using function declarations are fully hoisted, while function expressions are not hoisted (Y).

---

#### What is async/await in JavaScript?

`async` and `await` are keywords that simplify working with promises (W). `async` defines a function that returns a promise, while `await` pauses the execution of the function until the promise resolves (H). These keywords make asynchronous code easier to read and maintain (Y).

---

### Should Have

---

#### How do you create arrays in JavaScript?

Arrays in JavaScript are created using the array literal syntax `[]` (W). Arrays can store multiple elements of any data type and can be manipulated using array methods like `push()`, `pop()`, `shift()`, and `unshift()` (H). Arrays are a fundamental data structure in JavaScript (Y).

---

#### What are some array methods in JavaScript?

JavaScript arrays have many methods for iteration and manipulation, such as `forEach()`, `map()`, `filter()`, `reduce()`, and `sort()` (W). These methods allow for efficient handling and transformation of data in arrays (H). Familiarity with array methods is crucial for effective data manipulation (Y).

---

#### What are functions in JavaScript?

Functions in JavaScript are blocks of code designed to perform a specific task (W). They can be declared in several ways: as function declarations, expressions, or arrow functions (H). Functions are reusable, allowing for better modularity and readability in code (Y).

---

#### What are template literals in JavaScript?

Template literals are strings that allow embedded expressions (W). They are enclosed in backticks `` ` `` and can include placeholders for variables or expressions using `${}` (H). Template literals simplify string concatenation and improve readability (Y).

---

#### How do you loop through arrays in JavaScript?

Arrays in JavaScript can be iterated using loops like `for`, `forEach()`, `map()`, and `for...of` (W). Each method has different use cases for iterating over array elements and performing operations (H). Knowing how to loop efficiently is essential for working with collections of data (Y).

---

#### How do you insert new elements into the DOM?

New elements can be inserted into the DOM using methods like `document.createElement()` and `appendChild()` or `insertBefore()` (W). These methods allow you to dynamically add elements to the DOM, which is essential for creating interactive web pages (H).

---

#### How do you handle a failed request with Fetch API?

A failed request in Fetch can be handled using the `.catch()` method or by checking the `Response.ok` property (W). This helps in managing errors such as network issues or server failures (H). Proper error handling is important for building robust applications (Y).

---

#### What is the `this` keyword in JavaScript?

The `this` keyword refers to the context in which a function is called (W). It can refer to different things depending on how the function is invoked, such as an object or the global scope (H). Understanding `this` helps in controlling the behavior of functions and objects in JavaScript (Y).

---

### Advanced

---

#### What are callback functions in JavaScript?

A callback function is a function passed into another function as an argument and is executed later (W). Callbacks are commonly used in asynchronous operations, such as reading files or handling events (H). Understanding callbacks is important for managing async behavior and event handling in JavaScript (Y).

---

#### What are arrow functions in JavaScript?

Arrow functions are a concise syntax for writing functions in JavaScript (W). They allow for shorter function expressions and automatically bind the value of `this` to the surrounding context (H). Arrow functions improve code readability and maintainability (Y).

---

#### What are anonymous functions in JavaScript?

Anonymous functions are functions that are defined without a name (W). They are often used as arguments to other functions or for immediate execution (H). Anonymous functions are helpful for quick operations and callback functions (Y).

---

#### What is the difference between `for...of` and `for...in` loops?

`for...of` iterates over the values of iterable objects (like arrays), while `for...in` iterates over the keys (or property names) of an object (W). Understanding the distinction helps avoid errors when iterating over different types of data structures (H). Using the correct loop improves the clarity and performance of the code (Y).

---

#### What are some methods on the event object in JavaScript?

The event object provides properties and methods related to the event being triggered (W). Methods like `preventDefault()`, `stopPropagation()`, and `target` are used to control event behavior and interact with the element that triggered the event (H). Familiarity with the event object is crucial for handling events effectively (Y).

---

#### What are the different promise methods in JavaScript?

Promises in JavaScript have methods like `then()`, `catch()`, and `finally()` for chaining actions (W). These methods allow you to handle asynchronous operations and their results or errors (H). Mastery of promises is important for writing clean asynchronous code (Y).

---

#### What is a closure in JavaScript?

A closure is a function that "remembers" the lexical scope in which it was defined, even after that scope has exited (W). Closures are often used for data encapsulation and maintaining state in JavaScript (H). Understanding closures is key to advanced JavaScript patterns and managing scope effectively (Y).

---

#### What are modules in JavaScript?

Modules in JavaScript allow you to split code into separate files for better organization (W). ES6 introduced the `import` and `export` syntax for module loading (H). Modules help in managing large applications and improving code maintainability (Y).

---
