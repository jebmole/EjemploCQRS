using Ejemplo.Application;
using Ejemplo.Application.Interfaces;
using Ejemplo.Infrastructure.Persistence.DbContexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Se registra la DB
builder.Services.AddDbContext<EjemploContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Ejemplo"));
});

builder.Services.AddTransient<IApplicationDbContext, EjemploContext>();
builder.Services.AddApplicationServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
