//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IArgumentValidator{T}.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

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