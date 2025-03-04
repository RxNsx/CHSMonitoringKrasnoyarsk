using System.Reflection;
using CHSMonitoring.API.Middlewares;
using CHSMonitoring.Application;
using CHSMonitoring.Infrastructure;
using CHSMonitoring.Infrastructure.Context;
using CHSMonitoring.Infrastructure.Interfaces.Workers;
using CHSMonitoring.Infrastructure.Services;
using CHSMonitoring.Infrastructure.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.ConfigureTelegramBotMvc();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORSPOLICY", config =>
    {
        config
            .WithOrigins("http://localhost:3000")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Configuration
    .AddJsonFile("appsettings.json")
    .AddJsonFile("appsettings.Development.json", false)
    .AddUserSecrets(Assembly.GetEntryAssembly()!);

builder.Services
    .AddInfrastructureServices(builder.Configuration)
    .AddApplicationServices();

builder.Services.Configure<AuthSettings>(builder.Configuration.GetSection("AuthSettings"));
var authSettings = builder.Configuration.GetSection("AuthSettings").Get<AuthSettings>();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidIssuer = authSettings!.Issuer,
            ValidateIssuer = true,
            ValidAudience = authSettings.Audience,
            ValidateAudience = true,
            ValidateIssuerSigningKey = true,
            RequireExpirationTime = true,   
            IssuerSigningKey = AuthSettings.GetSymmetricSecurityKey()
        };
    });
builder.Services.AddAuthorization();

//HttpClient
builder.Services.AddHttpClient<HttpClientService>(client =>
{
    client.Timeout = TimeSpan.FromMinutes(1);
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<MonitoringDbContext>();
    if ((await dbContext.Database.GetPendingMigrationsAsync()).Any())
    {
        await dbContext.Database.MigrateAsync();
    }
}

app.UseCookiePolicy(new CookiePolicyOptions()
{
    HttpOnly = HttpOnlyPolicy.Always
});

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<RequestMiddleware>();

app.UseCors("CORSPOLICY");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();