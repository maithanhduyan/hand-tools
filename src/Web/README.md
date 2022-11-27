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

- [Database to Models](learnentityframeworkcore.com/walkthroughs/existing-database)
> mkdir Domain
> cd Domain
> dotnet new console
> dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
> dotnet add package Microsoft.EntityFrameworkCore.Design
> dotnet ef dbcontext scaffold "Host=localhost;Database=nijimise_db;Username=postgres;Password=123" Npgsql.EntityFrameworkCore.PostgreSQL -o Models

- Reference Project
    - List
> dotnet list reference
> learnentityframeworkcore.com/walkthroughs/existing-database


- API Controller
~~~~
// For Api
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

...
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

...

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Api
    endpoints.MapControllers();
});
~~~~

> dotnet-aspnet-codegenerator controller -name ProductsController -async -api -m Product -dc AppDbContext -outDir Api
> dotnet-aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc AppDbContext -outDir Api

### References
- UI
[Google Icon](https://fonts.google.com/icons)

- Back-End
[Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)