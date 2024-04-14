
using Application.Extensions;
using Infrastructure.Extensions;
using Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDbContext();
builder.Services.RegisterRepositories();

builder.Services.RegisterUseCases();

builder.Services.RegisterEndpoints();
builder.Services.RegisterOpenAPI();

var app = builder.Build();

app.RegisterMiddlewares();

app.MapEndpoints();

app.Run();
