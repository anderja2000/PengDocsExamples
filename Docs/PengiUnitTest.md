# <span style="color: pink;">Guide for Running Unit Tests</span>

## Folder Structure 
```
P0_KYLIE_WILSON
│
├── TaskManager.App
│   ├── Menu.cs
│   ├── Program.cs
│   └── TaskManager.App.csproj
│
└── TaskManager.Tests
|   ├── UnitTest.cs
|   └── TaskManager.Tests.csproj
|
└── TaskManagerSLN.sln
```

## How to run user tests

First switch your terminal to <span style="color: purple;">git</span>
<span style="color: yellow;">bash</span>
(it'll give you the bash color indicator and make the terminal easier to use)

1. type pwd <span style="color: yellow;">(*print current working directory*)</span> command  to see what directory you're in

    ``` pwd ```
2. Navigate to the Tesing Folder you made <span style="color: orange;
">*TaskManager.Tests*</span>

    ``` cd TaskManger.Tests ```

3. Now that you're in you're <span style="color: orange;
">*TaskManager.Tests*</span> folder use to run your tests

    ``` dotnet test  ```

