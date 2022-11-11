# Web

- ASP Dotnet Core MVC scaffolding 
~~~~
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
~~~~
- with Postgresql
> dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

- Create CRUD with Movie Entity
> dotnet aspnet-codegenerator controller -name ProductController -m Product -dc Web.Data.AppDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
- Create migration file InitialCreate
>dotnet ef migrations add InitialCreate
- update database
>dotnet ef database update

- Run project in Production
> dotnet run --environment Production
- Run project with profile
> dotnet run --launch-profile "http"

### References
- UI
[Google Icon](https://fonts.google.com/icons)

- Back-End
[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)