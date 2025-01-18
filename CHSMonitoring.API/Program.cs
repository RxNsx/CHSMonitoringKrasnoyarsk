using CHSMonitoring.API.HttpClients;
using CHSMonitoring.API.Interfaces;
using CHSMonitoring.API.Services;
using CHSMonitoring.API.Workers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Scoped Services

//Singleton Services
builder.Services.AddSingleton<IHttpClientService, HttpClientService>();
builder.Services.AddSingleton<IHtmlParserService, HtmlParserService>();
builder.Services.AddSingleton<ITdContentParserService, TdContentParserService>();

//HttpClient
builder.Services.AddHttpClient<HttpClientService>(client =>
{
    client.Timeout = TimeSpan.FromMinutes(1);
});

//Workers
builder.Services.AddHostedService<ServiceMessageWorker>();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (!app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();