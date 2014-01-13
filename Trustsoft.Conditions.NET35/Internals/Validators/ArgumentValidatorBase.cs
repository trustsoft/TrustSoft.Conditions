//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ArgumentValidatorBase.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    /// <summary>
    ///     Base class for all <see cref="IArgumentValidator{T}"/> implementations.
    /// </summary>
    /// <typeparam name="T"> </typeparam>
    internal class ArgumentValidatorBase<T> : IArgumentValidator<T>
    {
        #region " Constructors / Destructors "

        /// <summary>
        ///     Initializes a new instance of the <see cref="ArgumentValidatorBase{T}"/> class.
        /// </summary>
        /// <param name="argument"> The argument. </param>
        /// <param name="errorHandler"> The error handler. </param>
        protected ArgumentValidatorBase(IArgument<T> argument, IErrorHandler<T> errorHandler)
        {
            this.Argument = argument;
            this.ErrorHandler = errorHandler;
            this.ErrorHandler.Validator = this;
        }

        #endregion

        #region " Implementation of IArgumentValidator<T> "

        /// <summary>
        ///     Gets the argument.
        /// </summary>
        /// <value> The argument. </value>
        public IArgument<T> Argument { get; private set; }

        /// <summary>
        ///     Gets the error handler.
        /// </summary>
        /// <value> The error handler. </value>
        public IErrorHandler<T> ErrorHandler { get; private set; }

        #endregion
    }
}