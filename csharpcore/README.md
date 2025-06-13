# ShiMart

This is the ShiMart kata in C#/.NET. If you have an IDE you're comfortable with (Visual Studio, Visual Studio Code, JetBrains Rider), you can run all these operations from within the IDE. If you prefer command line, guidance is provided below.

## Getting started

### Prerequisites

- .NET 8.0 SDK or later
- Your preferred IDE (Visual Studio, Visual Studio Code, JetBrains Rider, etc.)

### Verify .NET installation

```sh
dotnet --version
```

This should show version 8.0.x or higher.

## Build the project

From the solution directory (csharpcore):

```sh
dotnet build
```

## Run the application

From the solution directory:

```sh
dotnet run --project ShiMart
```

Or navigate to the ShiMart project directory and run:

```sh
cd ShiMart
dotnet run
```

## Run the unit tests

From the solution directory:

```sh
dotnet test
```

To run tests with more detailed output:

```sh
dotnet test --verbosity normal
```

## Watch mode (auto-rebuild on file changes)

For development, you can use watch mode to automatically rebuild and run tests when files change:

```sh
dotnet watch test --project ShiMartTest
```

Or to watch and run the application:

```sh
dotnet watch run --project ShiMart
```