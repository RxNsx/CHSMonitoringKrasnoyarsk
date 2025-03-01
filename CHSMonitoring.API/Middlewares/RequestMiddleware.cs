using System.Text;

namespace CHSMonitoring.API.Middlewares;

/// <summary>
/// Конвеер отображения запроса
/// </summary>
public class RequestMiddleware
{
    private readonly RequestDelegate _next;
    private ILogger<RequestMiddleware> _logger;

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="next"></param>
    public RequestMiddleware(ILogger<RequestMiddleware> logger, RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation($"Заголовки входящего запроса");
        foreach (var header in context.Request.Headers)
        {
            _logger.LogInformation($"{header.Key} : {header.Value}");
        }

        if (context.Request.Body.CanRead)
        {
            context.Request.EnableBuffering();
            using var reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, leaveOpen: true);
            var body = await reader.ReadToEndAsync();

            if (context.Request.Path.HasValue)
            {
                _logger.LogInformation($"Входящий запрос{context.Request.Path.Value}");
            }
            
            _logger.LogInformation($"Тело входящего запроса {body}");
            context.Request.Body.Position = 0;
        }
        
        _logger.LogInformation($"Конец данных о запросе");
        await _next(context);
    }
}