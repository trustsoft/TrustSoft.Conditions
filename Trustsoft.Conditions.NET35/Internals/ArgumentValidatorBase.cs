//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ArgumentValidatorBase.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    internal class ArgumentValidatorBase<T> : IArgumentValidator<T>
    {
        #region " Implementation of IArgumentValidator<T> "

        public IArgument<T> Argument { get; private set; }

        public IErrorHandler<T> ErrorHandler { get; private set; }

        #endregion

        protected ArgumentValidatorBase(IArgument<T> argument, IErrorHandler<T> errorHandler)
        {
            this.Argument = argument;
            this.ErrorHandler = errorHandler;
            this.ErrorHandler.Validator = this;
        }
    }
}