using BreadWatch.Business;
using BreadWatch.Business.Interfaces;
using BreadWatch.Data;
using BreadWatch.Entities;
using BreadWatch.Helpers;
using BreadWatch.Repo;
using BreadWatch.Repo.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BreadContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<BreadContext>();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));

//DI
builder.Services.AddScoped<IExpenseRepo, ExpenseRepo>();
builder.Services.AddScoped<IExpenseManager, ExpenseCategory>();

builder.Services.AddScoped<IBudgetRepo, BudgetRepo>();
builder.Services.AddScoped<IBudgetManager, BudgetManager>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(c =>
 {
     c.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
 });

app.UseAuthorization();

app.MapControllers();

app.Run();
