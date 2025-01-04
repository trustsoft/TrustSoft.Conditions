// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="IErrorHandler{T}.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

/// <summary>
///   Represents an error handler.
/// </summary>
/// <typeparam name="T"> The type of argument value. </typeparam>
public interface IErrorHandler<T>
{
    /// <summary>
    ///   Gets or sets the validator.
    /// </summary>
    /// <value> The validator. </value>
    IArgumentValidator<T> Validator { get; set; }

    /// <summary>
    ///   Posts the error of specified <paramref name="violationType"> type </paramref> to handler.
    /// </summary>
    /// <param name="violationType"> The type of violation. </param>
    /// <param name="message"> The error message. </param>
    void Post(ViolationType violationType, string message);

    /// <summary>
    ///   Posts the specified error to handler.
    /// </summary>
    /// <param name="message"> The message. </param>
    void Post(string message);
}