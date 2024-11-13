

---

# ASP.NET Core Knowledge Base

---

### Must Have

---

#### What is ASP.NET Core?

ASP.NET Core is a high-performance, cross-platform framework for building web applications and APIs (W). It is designed to be lightweight, modular, and highly scalable (H). ASP.NET Core is a key framework in .NET for developing modern web applications (Y).

---

#### What is a Controller in ASP.NET Core?

A controller in ASP.NET Core handles incoming HTTP requests, processes them, and returns appropriate responses (W). It is the central part of the MVC (Model-View-Controller) pattern (H). Controllers define action methods that respond to specific routes (Y).

---

#### How does controller-based routing work?

Controller-based routing in ASP.NET Core uses route attributes to map URLs to controller actions (W). The `Route` attribute specifies the URL pattern, and action methods are triggered based on the matched route (H). This routing system allows developers to design RESTful APIs and web applications efficiently (Y).

Example:
```csharp
[HttpGet("api/pets/{id}")]
public ActionResult<Pet> GetPet(int id) { ... }
```

---

#### How do you create endpoints in ASP.NET Core?

Endpoints in ASP.NET Core are created by defining action methods in controllers with route attributes (W). These methods handle specific HTTP verbs (GET, POST, PUT, DELETE) and URLs (H). This enables the creation of APIs with RESTful endpoints (Y).

Example:
```csharp
[HttpPost("api/pets")]
public ActionResult CreatePet([FromBody] Pet pet) { ... }
```

---

#### What is appsettings.json and why do we use appsettings.Development.json?

`appsettings.json` contains configuration data used by an ASP.NET Core application (W). It typically stores values like database connection strings and application settings (H). `appsettings.Development.json` is used for environment-specific configurations, overriding values in `appsettings.json` for local development (Y).

Example:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=MyDb;"
  }
}
```

---

### Should Have

---

#### Achieve Dependency Injection in ASP.NET Core

ASP.NET Core uses dependency injection (DI) to manage services and their dependencies (W). Services are registered in `Program.cs`, and DI automatically injects them into controllers and other components (H). DI simplifies code management, testing, and improves maintainability (Y).

Example:
```csharp
builder.Services.AddScoped<IPetService, PetService>();
```

---

#### Implement Middleware in ASP.NET Core

Middleware components are used in the HTTP request pipeline to handle requests and responses (W). Middleware can perform tasks like logging, authentication, and exception handling (H). You configure middleware in `Program.cs` using `app.UseMiddleware<MyMiddleware>();` (Y).

Example:
```csharp
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
```

---

#### What are Filters in ASP.NET Core?

Filters in ASP.NET Core are used to run code before or after an action method executes (W). They are useful for cross-cutting concerns like logging, authorization, and validation (H). Filters can be applied globally, at the controller level, or the action method level (Y).

Example:
```csharp
public class MyActionFilter : IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context) { ... }
    public void OnActionExecuted(ActionExecutedContext context) { ... }
}
```

---

#### Implement Model Binding in ASP.NET Core

Model binding in ASP.NET Core maps incoming HTTP request data (from query strings, form data, route data, or the request body) to action method parameters (W). It allows controllers to automatically parse complex objects and bind them to parameters (H). Model binding simplifies controller code and helps handle user inputs more effectively (Y).

Example:
```csharp
public IActionResult CreatePet([FromBody] Pet pet) { ... }
```

---

#### How do you configure routes to accept different types of parameters?

ASP.NET Core routes can accept different types of parameters, including route parameters, query parameters, and request body data (W). You use attributes like `[FromRoute]`, `[FromQuery]`, and `[FromBody]` to specify how parameters are bound (H).

Examples:
```csharp
[HttpGet("pets/{id}")]
public ActionResult<Pet> GetPetById([FromRoute] int id) { ... }

[HttpGet("pets")]
public ActionResult<IEnumerable<Pet>> GetPets([FromQuery] string type) { ... }

[HttpPost("pets")]
public ActionResult CreatePet([FromBody] Pet pet) { ... }
```

---

### Nice to Have

---

#### What is CORS, and how do you configure it in ASP.NET Core?

CORS (Cross-Origin Resource Sharing) allows servers to specify which domains can access resources on the server (W). In ASP.NET Core, you can configure CORS policies in `Program.cs` to control access to your application from different domains (H). This is essential for security when building APIs that will be consumed by web frontends from different origins (Y).

Example:
```csharp
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", policy =>
    {
        policy.WithOrigins("https://www.example.com")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
```

---

#### What is OpenAPI in ASP.NET Core?

OpenAPI is a specification for describing RESTful APIs (W). It allows you to define the structure and functionality of an API in a machine-readable format (H). ASP.NET Core supports OpenAPI (via Swagger) to generate documentation and help with client generation (Y).

Example (Swagger setup):
```csharp
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
});
```

---

### Advanced Concepts

---

#### How do you set up session management in ASP.NET Core?

Session management in ASP.NET Core allows you to store user-specific data between requests (W). This is useful for scenarios like user authentication (H). You configure session services and use them to store data in `Program.cs` (Y).

Example:
```csharp
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
```

---

#### What is Authentication and Authorization in ASP.NET Core?

Authentication verifies the identity of a user, while authorization determines whether a user has permission to access a resource (W). Authentication typically involves login mechanisms, and authorization ensures that users can only access resources they are allowed to (H). ASP.NET Core provides built-in support for both via `Identity` and `Claims-based Authorization` (Y).

Example (Authentication setup):
```csharp
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options => { options.LoginPath = "/Account/Login"; });
```

--- 
