
using Application.Extensions;
using Infrastructure.Extensions;
using Presentation.Extensions;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterDbContext(builder.Configuration);
builder.Services.RegisterRepositories();

builder.Services.RegisterUseCases();

builder.Services.RegisterEndpoints();
builder.Services.RegisterOpenAPI();

WebApplication app = builder.Build();

app.RegisterMiddlewares();

app.MapEndpoints();

app.Run();
