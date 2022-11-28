using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HandTools.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

#region Database Context
if (builder.Environment.IsDevelopment())
{
    // Develpoment
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Postgresql") ?? throw new InvalidOperationException("Connection string 'Postgresql' not found.")) );
    // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
}
else
{
    // Production
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("Postgresql") ?? throw new InvalidOperationException("Connection string 'Postgresql' not found.")));
    // AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
}
#endregion

#region services to the container.

// For Api
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// For WebUI
builder.Services.AddControllersWithViews();
#endregion

var app = builder.Build();

#region  Swagger Api
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
#endregion

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

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    // Api
    endpoints.MapControllers();
});

app.Run();
