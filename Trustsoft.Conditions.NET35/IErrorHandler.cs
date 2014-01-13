//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    /// <summary>
    ///     Represents an error handler.
    /// </summary>
    /// <typeparam name="T"> The type of argument`s value. </typeparam>
    public interface IErrorHandler<T>
    {
        /// <summary>
        ///     Posts the error of specified <paramref name="violationType"> type </paramref> to handler.
        /// </summary>
        /// <param name="violationType"> The type of violation. </param>
        /// <param name="message"> The error message. </param>
        void Post(ViolationType violationType, string message);

        /// <summary>
        ///     Posts the specified error to handler.
        /// </summary>
        /// <param name="message"> The message. </param>
        void Post(string message);

        /// <summary>
        ///     Gets or sets the validator.
        /// </summary>
        /// <value> The validator. </value>
        IArgumentValidator<T> Validator { get; set; }
    }
}