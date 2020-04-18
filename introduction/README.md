# Introducing C# and .NET

You'll need to install [.NET Core SDK](https://dotnet.microsoft.com/download/dotnet-core/current/runtime).

Check your installation was succesfull with `dotnet --info`.

## .NET

* CLR - Common Language Runtime
* FCL - Framework Class Library (Also known as Base Class Library)
* [NuGet - Packate Manager](https://www.nuget.org/)

#### Two .NET Frameworks

* .NET or .NET Framework (Windows Only)
* .NET Core (Linux, Mac, Windows, ARM) - Open Source

## Basic Commands

Check `./gradebook` folder for our first demo project.

You can create your first "Hello World" application running `dotnet new console` and start it with `dotnet run`. This will handle for you `dotnet restore` and `dotnet build`.

You can pass console parameters as strings like this: `dotnet run -- <param>`.

You can create a reference wihin two projects, for example, go to `gradebook/test/GradeBook.Tests` project, and run `dotnet add reference ../../src/GradeBook/GradeBook.csproj`. Now you can build the project and run `dotnet test`.

Create a solution file, go to the root directory `gradebook`, and run `dotnet new sln`, then add the projects with `dotnet sln add <file.csproj>`. Now you are able to run from the `gradebook` folders both projects with `dotnet run` and `dotnet test`.