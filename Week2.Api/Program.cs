using Microsoft.EntityFrameworkCore;
using Week2.Api.DataAccess.Concrete;
using Week2.Api.Utilities.DataGenerators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Use Ef Core InMemory Db
builder.Services.AddDbContext<ApiDbContext>(options => options.UseInMemoryDatabase(databaseName: "ApiDB"));

var app = builder.Build();

// Initalize InMemory Db with static Product data
app.GenerateProducts();

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
