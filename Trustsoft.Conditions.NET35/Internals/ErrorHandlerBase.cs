//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ErrorHandlerBase.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System;

    #endregion

    internal class ErrorHandlerBase<T> : IErrorHandler<T>
    {
        #region Implementation of IErrorHandler

        public virtual void Handle(ViolationType violationType, string message)
        {
            throw new ArgumentException(message);
        }

        public virtual void Handle(string message)
        {
            this.Handle(ViolationType.Default, message);
        }

        public IArgumentValidator<T> Validator { get; set; }

        #endregion
    }
}