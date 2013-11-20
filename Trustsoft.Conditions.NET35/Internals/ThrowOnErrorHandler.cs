//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ThrowOnErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System;

    #endregion

    /// <summary>
    ///     Error handler that throws on error.
    /// </summary>
    internal class ThrowOnErrorHandler<T> : IErrorHandler<T>
    {
        #region " Implementation of IErrorHandler "

        public void Post(ViolationType violationType, string message)
        {
            throw this.BuildException(violationType, message);
        }

        public void Post(string message)
        {
            this.Post(ViolationType.Default, message);
        }

        public IArgumentValidator<T> Validator { get; set; }

        #endregion

        private Exception BuildException(ViolationType violationType, string message)
        {
            switch (violationType)
            {
                case ViolationType.OutOfRangeViolation:
                    return new ArgumentOutOfRangeException(this.Validator.Argument.Name, message);

                default:
                    // ReSharper disable CompareNonConstrainedGenericWithNull
                    if (this.Validator.Argument.Value == null)
                    {
                        return new ArgumentNullException(this.Validator.Argument.Name, message);
                    }
                    // ReSharper restore CompareNonConstrainedGenericWithNull
                    return new ArgumentException(message, this.Validator.Argument.Name);
            }
        }
    }
}