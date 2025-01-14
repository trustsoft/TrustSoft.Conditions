﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ArgumentValidatorBase.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

/// <summary>
///   Provides the base class for all <see cref="IArgumentValidator{T}" /> implementations.
/// </summary>
/// <typeparam name="T"> The type of the argument value to validate. </typeparam>
/// <typeparam name="TErrorHandler"> The type of error handler to use on validate. </typeparam>
internal abstract class ArgumentValidatorBase<T, TErrorHandler> : IArgumentValidator<T>
        where TErrorHandler : class, IErrorHandler<T>
{
    #region " Public Properties "

    /// <summary>
    ///   Gets the argument.
    /// </summary>
    /// <value> The argument. </value>
    public IArgument<T> Argument { get; }

    /// <summary>
    ///   Gets the error handler.
    /// </summary>
    /// <value> The error handler. </value>
    public TErrorHandler ErrorHandler { get; }

    #endregion

    #region " Constructors "

    /// <summary>
    ///   Initializes a new instance of the <see cref="ArgumentValidatorBase{T,TErrorHandler}" /> class.
    /// </summary>
    /// <param name="argument"> The argument. </param>
    /// <param name="errorHandler"> The error handler. </param>
    protected ArgumentValidatorBase(IArgument<T> argument, TErrorHandler errorHandler)
    {
        this.Argument = argument;
        this.ErrorHandler = errorHandler;
        this.ErrorHandler.Validator = this;
    }

    #endregion

    #region " Implementation of IArgumentValidator<T> "

    /// <summary>
    ///   Gets the argument associated with this <see cref="IArgumentValidator{T}" /> object.
    /// </summary>
    /// <value> The argument. </value>
    IArgument<T> IArgumentValidator<T>.Argument => this.Argument;

    /// <summary>
    ///   Gets the error handle associated with this <see cref="IArgumentValidator{T}" /> object.
    /// </summary>
    /// <value> The error handler. </value>
    IErrorHandler<T> IArgumentValidator<T>.ErrorHandler => this.ErrorHandler;

    #endregion
}