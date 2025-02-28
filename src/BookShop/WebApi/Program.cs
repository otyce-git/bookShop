using BookShop.Modules.BookModule;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add Module Services
builder.Services.AddBookServices();
builder.Services.AddFastEndpoints();

var app = builder.Build();



app.UseHttpsRedirection();

app.UseFastEndpoints();

app.Run();