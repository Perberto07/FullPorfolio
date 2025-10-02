using Backend.Data;
using Backend.Services.AuthService;
using Backend.Services.ContentService;
using Backend.Services.JWTService;
using Backend.Services.NewsService;
using Backend.Services.ProjectService;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
        };
    });

builder.Services.AddDbContext<DataContext>(options => 
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
       policy =>
       {
           policy.WithOrigins("https://portfolio-perbertos-projects.vercel.app",
                              "http://localhost:65514",
                              "https://portfolio-hh2m6ynkq-perbertos-projects.vercel.app")
                 .AllowAnyHeader()
                 .AllowAnyMethod();
       });
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProjectServ, ProjectServ>();
builder.Services.AddScoped<IContentServ, ContentServ>();
builder.Services.AddScoped<INewsServ,  NewsServ>();
builder.Services.AddScoped<IJWTServ, JWTServ>();
builder.Services.AddScoped<IAuthServ, AuthService>();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DataContext>();
    db.Database.Migrate();   // applies any pending migrations
}
app.UseHttpsRedirection();
app.UseCors("AllowFrontend");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
