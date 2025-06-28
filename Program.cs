using Microsoft.EntityFrameworkCore;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Repositories;
using RockProjectBackend.Services;
using RockProjectBackend.Data;
// Ya no se necesita DotNetEnv

var builder = WebApplication.CreateBuilder(args);

// --- Servicios ---

// 1. Obtener la cadena de conexión del sistema de configuración de .NET
// (Localmente la tomará de User Secrets, en Azure la tomará de la configuración del App Service)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

if (string.IsNullOrEmpty(connectionString))
{
    // Este throw es importante. Si no encuentra la conexión, la app no debe arrancar.
    throw new InvalidOperationException("Connection string 'DefaultConnection' not found or is empty.");
}

// 2. Registrar el DbContext con la cadena de conexión obtenida
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

// 3. Registrar tus servicios y repositorios (Inyección de Dependencias)
builder.Services.AddScoped<IArtistaRepository, ArtistaRepository>();
builder.Services.AddScoped<IArtistaService, ArtistaService>();

// 4. Registrar los controladores
builder.Services.AddControllers();

// 5. Registrar los servicios para Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "AllowRemixApp",
                      policy  =>
                      {
                          // VERIFICA ESTA LÍNEA CARÁCTER POR CARÁCTER
                          policy.AllowAnyOrigin()
                                .AllowAnyHeader()
                                .AllowAnyMethod();
                      });
});

// --- Fin de Servicios ---

var app = builder.Build();

// --- Pipeline de Peticiones HTTP ---

// Habilitar Swagger en todos los entornos para este proyecto de curso
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowRemixApp"); 

// Habilitar los controladores para que respondan a las rutas
app.MapControllers();

// --- Fin del Pipeline ---

app.Run();
