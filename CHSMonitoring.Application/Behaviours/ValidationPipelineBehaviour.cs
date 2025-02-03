using FluentValidation;
using MediatR;

namespace CHSMonitoring.Application.Behaviours;

public class ValidationPipelineBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
    where TRequest : IRequest<TResponse>
{
    /// <summary>
    /// Валидаторы запросов
    /// </summary>
    private readonly IEnumerable<IValidator<TRequest>> _validators;
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="validators"></param>
    public ValidationPipelineBehaviour(IEnumerable<IValidator<TRequest>> validators)
    {
        this._validators = validators;
    }
    
    /// <summary>
    /// Обработчик валидации
    /// </summary>
    /// <param name="request"></param>
    /// <param name="next"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validators.Any())
        {
            var context = new ValidationContext<TRequest>(request);
            var validationResults = await Task.WhenAll(_validators
                .Select(v => v.ValidateAsync(context, cancellationToken)));

            var failures = validationResults
                .SelectMany(r => r.Errors)
                .Where(f => f is not null)
                .ToList();
            
            if (failures.Any())
            {
                throw new ValidationException(failures);
            }
        }
        return await next();
    }
}