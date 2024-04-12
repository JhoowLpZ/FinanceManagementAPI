using Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDbContext();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
