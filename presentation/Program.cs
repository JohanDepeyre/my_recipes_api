using Application.Managers;
using Application.Managers.Interfaces;
using Data.Data;
using Data.Repository;
using Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IRecetteManager, RecetteManager>();
builder.Services.AddScoped<IEtapeManager, EtapeManager>();
builder.Services.AddScoped<ICategorieManager, CategorieManager>();
builder.Services.AddScoped<IRecetteRepository, RecetteRepository>();
builder.Services.AddScoped<IEtapeRepository, EtapeRepository>();
builder.Services.AddScoped <ICategorieRepository, CategorieRepository>();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer("Server=DESKTOP-BRDLEPQ\\SQLEXPRESS;Database=my_recipes;Trusted_Connection=True;TrustServerCertificate=True;"));
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
