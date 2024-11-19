--- 

# Pengi Review
--- 

#### <span style="text-decoration: underline; color: pink;">How does controller-based routing work?</span>

Controller-based routing in ASP.NET Core uses route attributes to map URLs to controller actions (W). The `Route` attribute specifies the URL pattern, and action methods are triggered based on the matched route (H). This routing system allows developers to design RESTful APIs and web applications efficiently (Y).

#### What is serialization?

Serialization is the process of converting an object into a format suitable for storage or transmission , such as binary or XML(W) . It allows objects to be persisted or sent over networks(H) . Serialization facilitates data exchange between applications or saving application state across sessions(Y).

#### Describe SOLID
SOLID refers to five design principles aimed at making software designs more understandable , flexible , and maintainable(W):

S: Single Responsibility Principle (SRP)
The Single Responsibility Principle states that a class should have only one reason to change, focusing on a single responsibility or job. This leads to better maintainability and reduces the risk of bugs when requirements change.

O: Open/Closed Principle (OCP)
The Open/Closed Principle asserts that software entities should be open for extension but closed for modification, allowing new functionality to be added without altering existing code. This approach minimizes bugs and testing efforts when enhancing features.

L: Liskov Substitution Principle (LSP)
The Liskov Substitution Principle states that objects of a superclass should be replaceable with objects of a subclass without affecting the program's correctness. This ensures that subclasses maintain the expected behavior of their superclasses.

I: Interface Segregation Principle (ISP)
The Interface Segregation Principle suggests that no client should be forced to depend on methods it does not use, advocating for smaller, more specific interfaces. This promotes a more modular and flexible design, reducing the impact of changes.

D: Dependency Inversion Principle (DIP)
The Dependency Inversion Principle states that high-level modules should not depend on low-level modules; both should depend on abstractions. This principle encourages the use of interfaces or abstract classes to decouple components, enhancing flexibility and testability.

These principles guide developers towards better software architecture practices(H), leading to robust applications capable of adapting over time(Y).

What is Singleton pattern, and when do we use it?
The Singleton pattern ensures only one instance of a class exists throughout an application's lifecycle(W) . It restricts instantiation via private constructors while providing global access through static methods(H) . This pattern is useful when exactly one object needs coordinated access across various parts of an application(Y).