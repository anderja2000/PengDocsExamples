# React Knowledge Base

---

### Must Have

---

#### What is a component?

A component is a fundamental building block of a React application (W). It is essentially a function or a class that returns JSX, which is a syntax extension for writing HTML-like elements in JavaScript (H). Components make applications modular and manageable, as they break down complex UIs into smaller, reusable parts (Y).

---

#### What is the structure of a functional component?

A functional component is a React component defined as a JavaScript function (W). It returns JSX to define the UI layout and can utilize React hooks, such as `useState` and `useEffect`, to manage state and lifecycle methods (H). Functional components are preferred for their simplicity and the ability to use modern React features like hooks, which help reduce boilerplate and improve code performance (Y).

---

#### What is special about the App.tsx file?

The `App.tsx` file is the root component of a React application (W). It serves as the entry point of the app, where the main structure of the app is defined, including routing and rendering other components (H). It is special because it often houses the core application logic and sets the tone for the rest of the app’s component hierarchy (Y).

---

#### What is the virtual DOM?

The virtual DOM is a lightweight, in-memory representation of the real DOM (W). React uses it to track changes by first updating the virtual DOM, comparing it with the real DOM, and then determining the minimal set of changes needed (H). This process significantly improves performance, as it reduces the number of direct manipulations to the actual DOM, leading to faster and more efficient updates (Y).

---

#### What is an SPA? What are the advantages and disadvantages?

An SPA (Single Page Application) is a web application that loads a single HTML page and dynamically updates the content without reloading the entire page (W). SPAs use client-side routing to handle navigation between different views (H). The advantages include faster navigation, a seamless user experience, and better performance due to reduced page reloads (Y). The disadvantages, however, include SEO challenges and initial loading time, as the entire app’s JavaScript bundle is loaded upfront (Y).

---

#### What is routing?

Routing in React refers to navigating between different components or views based on the current URL (W). React Router is a common tool used to implement routing in React, where you define routes that match specific paths to render the corresponding components (H). Routing allows for dynamic navigation within a web application without reloading the page, providing a smooth and seamless user experience (Y).

---

#### How is a new route set up?

To set up a new route in React, you first wrap your app with `BrowserRouter` from React Router (W). Then, define individual `Route` components for each path, specifying the URL and the component that should be rendered when that path is matched (H). This approach enables dynamic, client-side routing without refreshing the page, leading to a faster and more fluid user experience (Y).

---

#### What are props?

Props (short for "properties") are a way to pass data from a parent component to a child component (W). They are passed as arguments into the child component, and the child can use them to render content dynamically (H). Props allow components to be reusable and flexible, as different data can be passed to the same component (Y).

---

#### What is state?

State is an object that holds data that can change over time in a component (W). It is initialized within the component and can be updated using methods like `setState` (for class components) or `useState` (for functional components) (H). State is essential because it allows components to be interactive, responding to user actions or other dynamic changes in the application (Y).

---

#### Are props mutable? Is state mutable?

Props are immutable, meaning they cannot be modified by the component that receives them (W). State, however, is mutable and can be updated using the `setState` method (class components) or the `useState` hook (functional components) (H). This distinction helps maintain predictable data flow, ensuring that the parent controls the props and the component can manage its own state independently (Y).

---

#### What is JSX?

JSX stands for JavaScript XML, and it is a syntax extension that allows you to write HTML-like elements within JavaScript (W). JSX is compiled into `React.createElement` calls, which React then uses to render elements to the screen (H). JSX simplifies the process of defining UI structures, allowing developers to combine HTML-like syntax and JavaScript logic in a single, cohesive format (Y).

---

#### What does it mean when there are curly braces `{}` in the return statement of a component?

Curly braces `{}` in JSX are used to embed JavaScript expressions inside the markup (W). Anything within the braces is treated as JavaScript code, allowing you to dynamically display values, perform calculations, or call functions within the UI (H). This feature enables React to render dynamic content based on the component's state, props, or any other JavaScript expression (Y).

---

#### How can you display a variable on your site in React (one-way binding)?

To display a variable in React, you use curly braces `{}` within the JSX to embed the value (W). For example, `{variableName}` will render the value of `variableName` inside the component’s UI (H). This is an example of one-way data binding, where the UI is updated automatically when the variable’s value changes (Y).

---

#### What is conditional rendering?

Conditional rendering in React allows you to render different components or elements based on a condition, such as a state or props (W). It is done using JavaScript expressions like `if`, `ternary operators`, or logical `&&` inside JSX (H). This feature allows the UI to adjust dynamically to different application states, providing an interactive experience for the user (Y).

---

#### How do I display an array of items as individual components in React?

To display an array of items as individual components, you can use the `map()` function to iterate over the array and render a component for each item (W). For example, `items.map(item => <ItemComponent key={item.id} {...item} />)` (H). This approach helps create a dynamic list of components based on an array of data (Y).

---

#### What are lists & keys in React?

Lists in React refer to arrays of elements or components, while keys are unique identifiers that React uses to keep track of each list item (W). Keys are passed as a `key` prop to each element in a list (H). Using keys improves performance by helping React identify which items have changed, been added, or been removed from the list (Y).

---

#### When does a component re-render?

A component re-renders when its state or props change (W). React compares the new values of state or props with the previous ones and triggers a re-render when changes are detected (H). Re-renders are necessary to update the UI and reflect changes in the component’s data, ensuring that the interface stays in sync with the underlying state (Y).

---

### Should Have

---

#### How is data binding done in React (one-way binding)?

Data binding in React is typically one-way, meaning that data flows from parent components to child components through props (W). The child component accesses the props and renders them in the UI (H). This unidirectional flow ensures clear data management and simplifies debugging and state management (Y).

---

#### How is event binding done in React?

Event binding in React is done by passing event handler functions as props to JSX elements, such as `onClick` or `onChange` (W). These handlers are triggered when the user interacts with the element (H). Event binding allows you to respond to user actions, like clicks or form submissions, and update the component state or trigger other actions (Y).

---

#### How can you retrieve input box data in React?

To retrieve input data in React, you use controlled components where the value of the input field is tied to the component’s state (W). You update the state using an `onChange` event handler, and React re-renders the component with the new input value (H). This ensures that the input data is always in sync with the component’s state (Y).

---

#### What is axios?

Axios is a promise-based HTTP client used for making requests to a server (W). It simplifies the process of fetching data from an API and handling the responses, providing a cleaner, more intuitive interface compared to the native `fetch` method (H). Axios is widely used because it supports async/await syntax and provides built-in error handling, making it easier to work with APIs (Y).

---

#### What is jest?

Jest is a testing framework created by Facebook, designed for testing JavaScript applications, especially React apps (W). It supports various testing strategies like unit testing, integration testing, and snapshot testing (H). Jest is popular because of its ease of use, built-in mocking capabilities, and seamless integration with React, helping ensure that code behaves as expected (Y).

---

#### What is shallow rendering?

Shallow rendering is a testing technique where only the component being tested is rendered, without rendering its child components (W). This technique is useful for unit testing components in isolation, ensuring that the focus remains on the behavior of the component itself (H). Shallow rendering makes tests simpler and faster by avoiding unnecessary renders of child components (Y).

---

#### What is mocking (conceptual)?

Mocking is a technique where you replace certain parts of your code, like functions or modules, with simplified mock versions (W). These mock versions simulate the behavior of real dependencies but are typically much simpler (H). Mocking is useful in unit testing to isolate the component being tested and prevent dependencies from affecting the test results (Y).

---

#### What is a Higher-Order Component (HOC)?

A Higher-Order Component (HOC) is a function that takes a component as an argument and returns a new component with enhanced behavior (W). HOCs allow you to reuse component logic without modifying the original component (H). They are often used for tasks like adding authentication or logging features to multiple components (Y).

---

#### What is a Pure Component?

A Pure Component is a type of React component that only re-renders when its props or state change (W). It is a performance optimization that prevents unnecessary re-renders, making applications more efficient (H). React’s `PureComponent` class performs a shallow comparison of props and state to determine if a re-render is needed (Y).

---

#### What is the significance of `key` in lists?

The `key` prop in lists is crucial for React to identify which items have changed, been added, or removed during a re-render (W). It helps React optimize the rendering process by updating only the necessary parts of the UI instead of re-rendering the entire list (H). Keys must be unique among siblings to prevent rendering issues (Y).

---

#### How is state managed in React?

State in React is managed through the `useState` hook in functional components or the `this.state` object in class components (W). State changes trigger a re-render of the component, ensuring that the UI reflects the latest data (H). For larger applications, state management solutions like Redux or Context API can be used to manage state across multiple components (Y).

---

#### What are Context and Context API in React?

The Context API in React provides a way to share state across components without passing props manually at every level (W). Context is useful for global data like user authentication, themes, or language preferences (H). The Context API is a simpler alternative to more complex state management libraries like Redux (Y).

---

### Nice to Have

---

#### What is redux?

Redux is a state management library used in JavaScript applications, including React (W). It allows you to manage global state across an entire application in a predictable way, with a single source of truth (H). Redux works with actions and reducers to update the state, making it easier to track changes and manage complex application logic (Y).

---

#### What is a reducer?

A reducer is a pure function in Redux that specifies how the state should change in response to an action (W). It takes the current state and an action as arguments and returns the new state (H). Reducers are essential for updating the global state in a consistent and predictable way, ensuring that state changes occur only through defined actions (Y).

---

#### What is the difference between functional and class components?

Functional components are simpler and defined as JavaScript functions, while class components are more complex and defined as ES6 classes (W). Functional components do not have lifecycle methods but can use React hooks like `useState` and `useEffect` to manage state and side effects (H). Class components have more built-in features but require more boilerplate and are less efficient in modern React development (Y).

---

#### What is the significance of `componentDidMount`?

The `componentDidMount` method is a lifecycle method in class components that is called once the component has been rendered to the screen (W). It is commonly used for tasks like fetching data from an API or subscribing to events (H). This method is essential for handling side effects that need to occur after the initial render, ensuring the component is set up correctly (Y).
