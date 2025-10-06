using minimal_api.Infrastructure.Data;
using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<DataContext>("Data Source=mininal_api.db");
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapPost("/login", (LoginDTO loginDto) => 
{
  if (loginDto.Email == "admin@teste.com" && loginDto.Password == "123456")
  {
    return Results.Ok("Login Done");
  }
  else
  {
    return Results.Unauthorized();
  }
});

app.Run();
