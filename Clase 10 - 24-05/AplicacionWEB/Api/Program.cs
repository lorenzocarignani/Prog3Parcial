using Api;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using Service.IServices;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Inyectamos el contexto nuestro (clase que hereda de DbContext) con el metodo AddDbContext() y le pasamos por parametro la ConnectionString definida en el archivo appsettings.json
builder.Services.AddDbContext<OrganizacionContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Hacemos la inyeccion de dependencia de nuestro servicio y la interface que implementa mediante el uso de AddScoped<T>()
builder.Services.AddScoped<IOrganizacionService, OrganizacionService>();
builder.Services.AddScoped<IProductoService, ProductoService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
