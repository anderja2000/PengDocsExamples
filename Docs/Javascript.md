# JavaScript Fundamentals

## Primitive Types in JavaScript

JavaScript supports several primitive types, which are the building blocks of data in the language:

1. **Number**: Represents both integer and floating-point numbers. Example: `let num = 42;`
2. **String**: Represents sequences of characters. Example: `let str = 'Hello, World!';`
3. **Boolean**: Represents a logical entity and can have two values: true or false. Example: `let isActive = true;`
4. **Undefined**: A variable that has been declared but not assigned a value. Example: `let x;`
5. **Null**: Represents the intentional absence of any object value. Example: `let y = null;`
6. **Symbol**: A unique and immutable primitive value introduced in ES6, often used as object property keys. Example: `let sym = Symbol('description');`
7. **BigInt**: A numeric type that can represent integers with arbitrary precision, introduced in ES2020. Example: `let bigInt = 1234567890123456789012345678901234567890n;`

## Variable Scopes in JavaScript

JavaScript has three main variable scopes that determine the accessibility of variables:

1. **Global Scope**: Variables declared outside any function or block are globally accessible. Example: `var globalVar = 'I am global';`
2. **Function Scope**: Variables declared within a function are only accessible within that function. Example: `function myFunc() { var localVar = 'I am local'; }`
3. **Block Scope**: Introduced with `let` and `const`, variables declared within a block (e.g., within `{}`) are only accessible within that block. Example: `if (true) { let blockVar = 'I am block scoped'; }`

## Differences Between let and const

1. **Reassignment**: `let` allows reassignment of its value, while `const` does not allow reassignment after its initial assignment. Example: `let x = 10; x = 20;` vs `const y = 10; y = 20; // Error`
2. **Initialization**: `const` must be initialized at the time of declaration, whereas `let` can be declared without initialization. Example: `let a; const b = 5;`
3. **Scope**: Both `let` and `const` are block-scoped, meaning they are only accessible within the block they are defined. Example: `if (true) { let a = 1; const b = 2; } // a and b are not accessible here`

# DOM Manipulation and Events

## Understanding the Document Object Model (DOM)

- The DOM is a programming interface that represents the structure of HTML and XML documents as a tree of objects.
- Each node in the tree corresponds to a part of the document, such as elements, attributes, and text.
- The DOM allows for dynamic manipulation of the document structure, style, and content using JavaScript.

## Selecting Elements from the DOM

1. `document.getElementById()`: Selects an element by its unique ID. Example: `document.getElementById('myId');`
2. `document.querySelector()`: Selects the first element that matches a specified CSS selector. Example: `document.querySelector('.myClass');`
3. `document.getElementsByClassName()`: Selects all elements with a specified class name. Example: `document.getElementsByClassName('myClass');`

## Steps to Add New Elements to a Webpage

1. **Create the Element**: Use `document.createElement()` to create a new element. Example: `let newDiv = document.createElement('div');`
2. **Set Attributes/Content**: Use properties like `innerHTML` or `setAttribute()` to set content or attributes. Example: `newDiv.innerHTML = 'Hello!';`
3. **Select Parent Element**: Use a selection method to find the parent element where the new element will be added. Example: `let parent = document.getElementById('parentId');`
4. **Append the New Element**: Use `appendChild()` or `insertBefore()` to add the new element to the parent. Example: `parent.appendChild(newDiv);`

## Event Handling in JavaScript

### Common Web Browser Events

1. `click`: Triggered when an element is clicked by the user.
2. `submit`: Triggered when a form is submitted.
3. `load`: Triggered when the page or an element has finished loading.
4. `keydown`: Triggered when a key is pressed down.
5. `mouseover`: Triggered when the mouse pointer moves over an element.

### Understanding Event Listeners

- Event listeners are functions that wait for a specific event to occur on a specified element.
- They execute a callback function in response to the event, allowing for interactive web applications.
- Example of adding an event listener: `element.addEventListener('click', function() { alert('Clicked!'); });`

### Event Propagation: Bubbling and Capturing

- **Bubbling**: The event starts from the target element and bubbles up through its ancestors in the DOM tree.
- **Capturing**: The event starts from the root of the DOM tree and travels down to the target element.
- Understanding these phases is crucial for managing event handling effectively.

# Asynchronous JavaScript

## Making HTTP Calls in JavaScript

1. **Fetch API**: A modern interface for making HTTP requests. Example: `fetch(url).then(response => response.json());`
2. **XMLHttpRequest**: An older method for making HTTP requests, still widely used. Example: `let xhr = new XMLHttpRequest();`
3. **Axios**: A popular third-party library for making HTTP requests with a simpler API. Example: `axios.get(url).then(response => console.log(response.data));`

## Understanding Promises

- A Promise is an object that represents the eventual completion or failure of an asynchronous operation.
- To handle success, use `.then()`, and for errors, use `.catch()`. Example: `promise.then(result => console.log(result)).catch(error => console.error(error));`
- Alternatively, use async/await syntax for cleaner asynchronous code. Example:
  ```javascript
  async function fetchData() {
    try {
      const data = await fetch(url);
    } catch (error) {
      console.error(error);
    }
  }****