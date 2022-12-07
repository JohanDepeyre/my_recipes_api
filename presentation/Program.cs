using Application.Managers;
using Application.Managers.Interfaces;
using Data.Data;
using Data.Model;
using Data.Repository;
using Data.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

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

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://127.0.0.1:5500"); 
                      });
});
builder.Services.AddAuthentication(option => {
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    option.SaveToken = true;
    string cle = "cleDeGuignol2022";
    option.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
    {
        IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(cle)),
        ValidateAudience = false,
        ValidateIssuer = false,
        ValidateActor = false,
        ValidateLifetime = true
    };


});

builder.Services.AddDefaultIdentity<IdentityUser>(option =>
{

}).AddEntityFrameworkStores<ApplicationDbContext>();
var app = builder.Build();

app.UseCors(MyAllowSpecificOrigins);
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();
