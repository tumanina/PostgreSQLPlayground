using Deployments.Api.Repositories;
using Deployments.Api.Services;
using Microsoft.EntityFrameworkCore;
using PostgreSqlPlayground.Database;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDeploymentHistoryRepository, DeploymentHistoryRepository>();
builder.Services.AddScoped<IDeploymentHistoryService, DeploymentHistoryService>();

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services
    .AddDbContext<PlaygroundContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=playgrounddb;Username=postgres;Password=postgres"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
