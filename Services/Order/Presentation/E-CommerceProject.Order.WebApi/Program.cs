using E_CommerceProject.Order.Application.Features.CQRS.Handlers;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Persistance.Context;
using E_CommerceProject.Order.Persistance.Repositories;
using Microsoft.AspNetCore.HttpLogging;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddMediatR(cfg =>
//{
//    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
//});

builder.Services.AddScoped<GetAddressQueryHandler>();
builder.Services.AddDbContext<OrderContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

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
