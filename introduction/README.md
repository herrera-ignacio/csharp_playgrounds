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

## Our First Project

Check `./gradebook` folder.

You can create your first "Hello World" application running `dotnet new console` and start it with `dotnet run`. This will handle for you `dotnet restore` and `dotnet build`.

You can pass console parameters as strings like this: `dotnet run -- <param>`.