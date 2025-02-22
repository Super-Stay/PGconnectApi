using Microsoft.EntityFrameworkCore;
using PGconnectApi.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddLogging(config => config.AddConsole());
builder.Services.AddDbContext<PgConnectDbContext>(opctions =>
opctions.UseMySQL(builder.Configuration.GetConnectionString("PgConnectDbContext")));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy => policy.WithOrigins("http://localhost:4200") // Change to Angular's URL
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular"); // Apply CORS Policy

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();






