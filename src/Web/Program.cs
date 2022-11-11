using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web.Models;
using Web.Data;

var builder = WebApplication.CreateBuilder(args);

#region Database Context
if (builder.Environment.IsDevelopment())
{
    // Develpoment
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Postgresql_AppDbContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));
    // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
}
else
{
    // Production
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Postgresql_AppDbContext") ?? throw new InvalidOperationException("Connection string 'MvcMovieContext' not found.")));
    // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
}
#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
