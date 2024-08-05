using FinalProg.Context;
using FinalProg.Repository;
using FinalProg.Repository.Impl;
using FinalProg.Services;
using FinalProg.Services.Impl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ISucursalService, SucursalService>();
builder.Services.AddTransient<ISucursalRepository, SucursalRepository>();

builder.Services.AddDbContext<SucursalesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("UserConnectionStrings")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => {
    options.AllowAnyOrigin();
    options.AllowAnyHeader();
    options.AllowAnyMethod();

});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
