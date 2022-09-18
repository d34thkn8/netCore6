//1.- importaciones EF
using Microsoft.EntityFrameworkCore;
using PrimeraApiDotNet6.DataAccess;
//using PrimeraApiDotNet6.DataAccess;
var builder = WebApplication.CreateBuilder(args);

//2.- String de conexión
const string CONNECTIONNAME = "AcademicoDB";
var connectionString=builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3.- Contexto de BD
builder.Services.AddDbContext<DBContext1>(options=>options.UseSqlServer(connectionString));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
