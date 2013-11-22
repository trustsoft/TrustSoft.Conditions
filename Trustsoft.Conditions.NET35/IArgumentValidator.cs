//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IArgumentValidator.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using Trustsoft.Conditions.Internals;

    #endregion

    /// <summary>
    ///     Represents an argument validator.
    /// </summary>
    /// <typeparam name="T"> The type of argument`s value. </typeparam>
    public interface IArgumentValidator<T> : IFluentSyntax
    {
        /// <summary>
        ///     Gets the argument associated wth the current <see cref="IArgumentValidator{T}"/> object.
        /// </summary>
        /// <value> The argument. </value>
        IArgument<T> Argument { get; }

        /// <summary>
        ///     Gets the error handle associated wth the current <see cref="IArgumentValidator{T}"/> object.
        /// </summary>
        /// <value> The error handler. </value>
        IErrorHandler<T> ErrorHandler { get; }
    }
}