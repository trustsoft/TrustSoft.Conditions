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
    /// <typeparam name="TErrorHandler"> </typeparam>
    internal class ArgumentValidatorBase<T, TErrorHandler> : IArgumentValidator<T>
        where TErrorHandler : IErrorHandler<T>
    {
        #region " Public Properties "

        /// <summary>
        ///     Gets the argument.
        /// </summary>
        /// <value> The argument. </value>
        public IArgument<T> Argument { get; private set; }

        /// <summary>
        ///     Gets the error handler.
        /// </summary>
        /// <value> The error handler. </value>
        public TErrorHandler ErrorHandler { get; private set; }

        #endregion

        #region " Constructors / Destructors "

        /// <summary>
        ///     Initializes a new instance of the <see cref="ArgumentValidatorBase{T,TErrorHandler}"/> class.
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
        ///     Gets the argument associated wth the current <see cref="IArgumentValidator{T}"/> object.
        /// </summary>
        /// <value> The argument. </value>
        IArgument<T> IArgumentValidator<T>.Argument
        {
            get
            {
                return this.Argument;
            }
        }

        /// <summary>
        ///     Gets the error handle associated wth the current <see cref="IArgumentValidator{T}"/> object.
        /// </summary>
        /// <value> The error handler. </value>
        IErrorHandler<T> IArgumentValidator<T>.ErrorHandler
        {
            get
            {
                return this.ErrorHandler;
            }
        }

        #endregion
    }
}