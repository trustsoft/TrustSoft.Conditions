//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ThrowOnErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    using System;

    /// <summary>
    ///     Error handler that throws on error.
    /// </summary>
    /// <typeparam name="T"> The type of the argument value to validate. </typeparam>
    internal class ThrowOnErrorHandler<T> : ErrorHandlerBase<T>
    {
        #region " Public Methods "

        /// <summary>
        ///     Posts the error of specified <paramref name="violationType"> type </paramref> to handler.
        /// </summary>
        /// <param name="violationType"> The type of violation. </param>
        /// <param name="message"> The error message. </param>
        public override void Post(ViolationType violationType, string message)
        {
            throw this.BuildException(violationType, message);
        }

        #endregion

        #region " Private Methods "

        private Exception BuildException(ViolationType violationType, string message)
        {
            switch (violationType)
            {
                case ViolationType.OutOfRange:
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

        #endregion
    }
}