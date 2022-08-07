using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using TodoMVC.Interfaces;
using TodoMVC.Models;
using TodoMVC.Profiles;
using TodoMVC.Repositories;
using TodoMVC.Services;

var builder = WebApplication.CreateBuilder(args);

// Services
var services = builder.Services;

services.AddDbContext<TodoContext>(opt =>
{
    opt.UseInMemoryDatabase("TodoInMemory");
});
services.AddMvc(opt =>
{
    opt.EnableEndpointRouting = false;
});
services.AddAutoMapper(typeof(MapperProfile));
services.AddSingleton<ITempDataDictionaryFactory, TempDataDictionaryFactory>();

services.AddScoped<ITodoServices, TodoServices>();

services.AddScoped<ITodoRepository, TodoRepository>();
// Configurations
var config = builder.Configuration;

// App pipeline
var app = builder.Build();

app.UseMvcWithDefaultRoute();

await app.RunAsync();
