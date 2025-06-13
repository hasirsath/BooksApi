using Microsoft.EntityFrameworkCore;
using BooksApi.Entity.Context;
using BooksApi.Services;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using BooksApi.Entity.Repositories.Interface;
using BooksApi.Entity.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BooksDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))); // Or UseSqlite, UsePostgreSQL, etc.
/*
 * AddSingleton - Single Instance For All Request
 * AddScoped - Single Instance For One Request
 * AddTransient - New Instance For Every Call
*/
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, IBookService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
