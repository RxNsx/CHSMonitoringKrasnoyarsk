using System.Reflection;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CHSMonitoring.Application.Behaviours;

/// <summary>
/// Пайплайн логгирования
/// </summary>
/// <typeparam name="TRequest"></typeparam>
/// <typeparam name="TResponse"></typeparam>
public class LoggingPipelineBehaviour<TRequest,TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> _logger;

    public LoggingPipelineBehaviour(ILogger<LoggingPipelineBehaviour<TRequest, TResponse>> logger)
    {
        _logger = logger;
    }
    
    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        _logger.LogInformation($"Request: {request}");
        var response = await next();
        _logger.LogInformation($"Response: {response}");
        return response;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Начало обработки команды {typeof(TRequest).Name}");
        var myType = request.GetType();
        
        IList<PropertyInfo> props = new List<PropertyInfo>(myType.GetProperties());
        foreach (var property in props)
        {
            var propertyValue = property.GetValue(request, null);
            _logger.LogInformation($"{property.Name} : {propertyValue}");
        }
        var response = await next();
        
        _logger.LogInformation($"Обработана команда {typeof(TResponse).Name}");
        return response;
    }
}