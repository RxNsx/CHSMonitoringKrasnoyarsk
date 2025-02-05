#nullable enable
using System;

namespace VplayRequestTransmitter.Shared;

/// <summary>
/// Result Pattern
/// </summary>
public class Result
{
    public bool IsSuccess { get; private set; }
    public Error Error { get; private set; }
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="isSuccess"></param>
    /// <param name="error"></param>
    /// <exception cref="Exception"></exception>
    protected internal Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None
            || !isSuccess && error == Error.None)
        {
            throw new Exception("Invalid operation result");
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    public static Result Success() => new(true, Error.None);
    public static Result Failure(Error error) => new(false, error);

    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);
    public static Result<TValue> Failure<TValue>(Error error) => new(value: default, false, error);
}

/// <summary>
/// Result Pattern Generic
/// </summary>
/// <typeparam name="TValue"></typeparam>
public class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue value, bool isSuccess, Error error) : base(isSuccess, error)
    {
        _value = value;
    }

    public TValue Value => IsSuccess
        ? _value
        : throw new InvalidOperationException("The value of a failure result cannot be accessed");
}