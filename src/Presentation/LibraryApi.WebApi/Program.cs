using System;
using LibraryApi.Persistence.Contexts;  // ✅ DbContext namespace-i
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ✅ Connection string oxu
var connectionString = builder.Configuration.GetConnectionString("Default");

// ✅ DbContext-i DI container-ə əlavə et
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
