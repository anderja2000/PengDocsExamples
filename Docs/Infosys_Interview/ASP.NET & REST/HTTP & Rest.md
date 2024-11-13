

# HTTP and REST Knowledge Base

### Must Have

#### What is HTTP?

`HTTP` (Hypertext Transfer Protocol) is a protocol for transmitting data over the internet (W). It defines how messages are formatted and transmitted between web browsers and servers (H). HTTP is the foundation of data communication on the World Wide Web, enabling the retrieval of web resources like HTML documents, images, and other content (Y).

#### Describe the parts of an HTTP Request and Response

An HTTP request consists of several components:

- **Request Line**: Contains the method (e.g., GET, POST), the resource URL, and the HTTP version.

- **Headers**: Key-value pairs providing additional information about the request (e.g., `Content-Type`, `User-Agent`).

- **Body**: Optional data sent to the server, typically used in POST or PUT requests.

An HTTP response similarly includes:

- **Status Line**: Contains the HTTP version, status code (e.g., 200 OK), and a reason phrase.

- **Headers**: Key-value pairs providing metadata about the response (e.g., `Content-Length`, `Content-Type`).

- **Body**: The main content returned to the client, such as HTML or JSON data.

These components structure how clients and servers communicate over HTTP (W). They ensure that requests and responses are properly formatted and contain all necessary information for successful interactions (H). Understanding these parts is crucial for effective web development and debugging (Y).

#### What is a header?

Headers in HTTP are additional pieces of information sent with requests or responses (W). They provide metadata about the request or response, such as content type, caching directives, or authentication tokens (H). Headers allow clients and servers to pass additional information with their messages, enhancing the flexibility and functionality of HTTP communications (Y).

#### What are HTTP request methods (verbs)?

HTTP request methods, also known as HTTP verbs, specify the desired action to be performed on the identified resource (W). Common methods include:

- `GET`: Retrieve a resource

- `POST`: Submit data to be processed

- `PUT`: Update an existing resource

- `DELETE`: Remove a resource

- `PATCH`: Partially modify a resource

These methods allow clients to interact with server resources in a standardized way (H). They are crucial for implementing RESTful APIs and defining the operations that can be performed on resources (Y).

#### What do you put in the request body?

The request body typically contains data sent to the server as part of `POST`, `PUT`, or `PATCH` requests (W). It can include form data, JSON payloads, or other types of content (H). The request body is used to send data that's too large or complex to be encoded in the URL, allowing clients to submit information to be processed by the server (Y).

#### What is a response code?

HTTP response codes are `three-digit status codes` returned by a server in response to an HTTP request (W). They indicate whether a specific HTTP request has been successfully completed or if an error occurred during processing (H). These codes help clients understand how their requests were handled by the server and what actions may need to be taken next (Y).

#### Describe 5 categories of response codes and what they mean in general

HTTP response status codes are grouped into five classes (W):

1\. `**1xx (Informational)**:` Request received, continuing process.

2\. `**2xx (Successful)**`: The request was successfully received, understood, and accepted.

3\. `**3xx (Redirection)*`*: Further action needs to be taken to complete the request.

4\. `**4xx (Client Error)**`: The request contains bad syntax or cannot be fulfilled.

5\. `**5xx (Server Error)**`: The server failed to fulfill a valid request.

These codes provide quick insight into the result of a request (H). They help in diagnosing issues and understanding the outcome of HTTP interactions (Y).

### Should Have

#### What are the REST principles?

The six main principles of REST are:

1\. `Client-Server`: `Separation of concerns` between the user interface and data storage.

2\. `Stateless`: Each request from client to server must contain all information needed to understand the request.

3\. `Cacheable`: Responses must define themselves as cacheable or not.

4\. `Uniform Interface`: A standardized way of interacting with a given server regardless of device or application type.

5\. `Layered System`: Client cannot tell whether it is connected directly to the end server or an intermediary.

6\. `Code on Demand (optional)`: Servers can temporarily extend client functionality by transferring executable code.

These principles guide the design of RESTful systems (W). They ensure `scalability`, `simplicity`, and `interoperability` in web services (H). Adhering to these principles results in more robust and maintainable APIs (Y).

#### What are URL conventions when using REST?

RESTful URL conventions typically follow these guidelines:

- Use `nouns` to represent resources (e.g., `/users`, `/products`).

- Use HTTP methods to represent actions on resources.

- Use plural nouns for collections (e.g., `/users` instead of `/user`).

- Use hierarchical relationships in URLs (e.g., `/users/123/orders`).

- Use query parameters for filtering, sorting, and pagination (e.g., `/products?category=electronics&sort=price`).

These conventions create intuitive and consistent APIs (W). They make APIs easier to understand and use for developers (H). Following these conventions improves the overall design and usability of RESTful services (Y).

#### What is SOA (Service Oriented Architecture)?

SOA is an architectural pattern for designing and developing distributed systems (W). It structures applications as a collection of loosely coupled services that communicate over a network (H). SOA promotes `reusability`, `scalability`, and `interoperability` in complex systems, allowing different parts of an application to be developed and maintained independently (Y).

Example diagram:

```

[Client] <--> [API Gateway] <--> [Service 1]

                   ^

                   |

                   v

             [Service 2] <--> [Database]

```

### Nice to Have

#### What is the difference between authorization and authentication?

Authentication is the process of verifying who a user is (W). It typically involves credentials like username and password (H). Authentication ensures that users are who they claim to be before granting access to a system (Y).

Authorization is the process of determining what resources a user has permission to access (W). It occurs after authentication and involves checking user rights and permissions (H). Authorization ensures that authenticated users only access resources they are allowed to, maintaining security and data integrity (Y).

#### How do you implement authentication and authorization in a RESTful API?

Authentication and authorization in RESTful APIs can be implemented using various methods:

1\.` JWT (JSON Web Tokens)`: Stateless authentication where the server issues a signed token upon login.

2\. `OAuth 2.0`: An authorization framework that enables third-party applications to obtain limited access to a web service.

3\. `API Keys`: Simple authentication using a unique key for each client.

Implementation typically involves:

1\. Creating an authentication endpoint (e.g., `/login`).

2\. Validating credentials and issuing tokens.

3\. Implementing middleware to check tokens on protected routes.

4\. Defining user roles and permissions for authorization.

These methods secure API endpoints (W). They ensure that only authenticated and authorized users can access protected resources (H). Proper implementation of authentication and authorization is crucial for maintaining security and integrity in RESTful services (Y).
sponse-cycle-in-node-js-works-with-external-i-o