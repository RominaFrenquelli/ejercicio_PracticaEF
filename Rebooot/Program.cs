using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rebooot.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ReboootContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReboootContext") ?? throw new InvalidOperationException("Connection string 'ReboootContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
             .AllowAnyMethod()
             .AllowAnyHeader()
             .SetIsOriginAllowed(origin => true) // allow any origin
             .AllowCredentials()); // allow credentials

app.UseAuthorization();

app.MapControllers();

app.Run();