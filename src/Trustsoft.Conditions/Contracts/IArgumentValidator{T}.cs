// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="IArgumentValidator{T}.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

/// <summary>
///   Represents an argument validator.
/// </summary>
/// <typeparam name="T"> The type of argument's value. </typeparam>
public interface IArgumentValidator<T> : IFluentSyntax
{
    /// <summary>
    ///   Gets the argument associated with the current <see cref="IArgumentValidator{T}" /> object.
    /// </summary>
    /// <value> The argument to validate. </value>
    IArgument<T> Argument { get; }

    /// <summary>
    ///   Gets the error handler associated with the current <see cref="IArgumentValidator{T}" /> object.
    /// </summary>
    /// <value> The error handler. </value>
    IErrorHandler<T> ErrorHandler { get; }
}