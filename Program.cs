using MinimalApi.DTOs;

var builder = WebApplication.CreateBuilder(args);
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
