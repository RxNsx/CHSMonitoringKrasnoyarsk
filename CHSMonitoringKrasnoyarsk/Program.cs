using CHSMonitoringKrasnoyarsk.HttpClients;
using CHSMonitoringKrasnoyarsk.Interfaces;
using CHSMonitoringKrasnoyarsk.Workers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Services
builder.Services.AddSingleton<IHttpClientService, HttpClientService>();

//HttpClient
builder.Services.AddHttpClient<HttpClientService>(client =>
{
    client.Timeout = TimeSpan.FromMinutes(1);
});

//Workers
builder.Services.AddHostedService<ChsParserWorker>();

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