# Create solution and console project
```
mkdir BackEndQuestions
cd BackEndQuestions
dotnet new sln
dotnet new console -o BackEndQuestions
dotnet sln add BackEndQuestions/BackEndQuestions.csproj
```

# Build and run the console application
```
dotnet restore
dotnet build
dotnet run --project BackEndQuestions
```

# Create a new xUnit test project and add a reference to the main project
```
dotnet new xunit -o BackEndQuestions.Tests
dotnet sln add BackEndQuestions.Tests/BackEndQuestions.Tests.csproj
dotnet add BackEndQuestions.Tests/BackEndQuestions.Tests.csproj reference BackEndQuestions/BackEndQuestions.csproj
```

# Run tests in the solution
```
dotnet test
```

# Add a new C# file to the BackEndQuestions app
```
touch BackEndQuestions/NewMainFile.cs
touch BackEndQuestions.Tests/NewTestFile.cs
```

# Add a new C# file to the main project
```
mkdir -p BackEndQuestions/business
touch BackEndQuestions/business/BusinessLogic.cs
```

# Add a new C# file to the test project
```
mkdir -p BackEndQuestions.Tests/business
touch BackEndQuestions.Tests/business/BusinessLogicTests.cs
```

Based on the following question below:


Can you write a method in csharp using clean code and best software engineering practices?