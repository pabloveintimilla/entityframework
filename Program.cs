using entityframework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/// Register inmemory database service
// builder.Services.AddDbContext<DataBaseContext>(db => db.UseInMemoryDatabase("TaskDB"));

/// Get connection string from appsettings
string connection = builder.Configuration.GetConnectionString("TaskDb");
/// Register postgres database service.
builder.Services.AddNpgsql<DataBaseContext>(connection);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

/// Verify if database is created if not creaated
app.MapGet("/dbconnect", ([FromServices] DataBaseContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok($"Database: {dbContext.Database.GetConnectionString()}");
});


app.Run();
