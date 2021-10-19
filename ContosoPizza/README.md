# REST Api

This repo contains the code from the course [Create a web API with ASP.NET core](https://docs.microsoft.com/en-us/learn/modules/build-web-api-aspnet-core/) of Microsot learn

## Getting started

With dotnet installed, run the following command to create a project structure using
an ASP.NET Core template:

```powershell
dotnet new webapi --no-https
```

The `--no-https` flag is for simplicity. Look [here](https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl#trust-the-aspnet-core-https-development-certificate-on-windows-and-macos) about how to configure HTTPS.

Build and run the app:

```powershell
dotnet build
dotnet run
```

## HTTP REPL

Install HTTP REPL for testing HTTP requests:

```powershell
dotnet tool install -g Microsoft.dotnet-httprepl
```

Connect REPL to the server:

```powershell
httprepl http://localhost:5000
```

While executing REPL on the terminal, you can:

-   list all available endpoints -> `ls`
-   navigate to an endpoint -> `cd SOME_ENDPOINT`
-   make a `get` request -> `get`
-   close REPL -> `exit`

## Data store

The file _/Models/Pizza.cd_ contains the model class to represent the pizza in the inventory.

The data required by this app will be stored in memory, using the code on
_/Services/PizzaService.cs_. To connect to a database, use
[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

## Controller

> A controller is a public class with one or more public methods known as actions. By convention, a controller is placed in the project root's Controllers directory. The actions are exposed as HTTP endpoints inside the web API controller.
