using Microsoft.EntityFrameworkCore;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Repositories;
using RockProjectBackend.Services;
using RockProjectBackend.Data;
using DotNetEnv;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

// Cargar variables de entorno desde .env
Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (connectionString == null)
{
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
}
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IArtistaRepository, ArtistaRepository>();
builder.Services.AddScoped<IArtistaService, ArtistaService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
