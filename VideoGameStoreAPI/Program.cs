using System.IO;
using API.Repositories.Interfaces;
using API.Repositories.Repositories;
using API.Service.Interfaces;
using API.Service.Service;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Dependencies
builder.Services.AddScoped<IVideoGameService, VideoGameService>();
builder.Services.AddScoped<IVideoGameRepositories, VideoGameRepositories>();

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
