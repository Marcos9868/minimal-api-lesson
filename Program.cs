using minimal_api.Domain.DTOs;
using minimal_api.Domain.ViewModels;
using minimal_api.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSqlite<DataContext>("Data Source=mininal_api.db");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

#region Home
app.MapGet("/", () => Results.Json(new Home()));
#endregion

#region Vehicle
app.MapPost("/Vehicles/login", (VehicleDTO vehicle, LoginDTO loginDto) => 
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
#endregion

app.Run();
