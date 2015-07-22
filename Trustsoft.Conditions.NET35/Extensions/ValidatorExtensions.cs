//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    using Trustsoft.Conditions.Internals;

    #endregion

    /// <summary>
    ///     Contains extension methods for <see cref="IArgumentValidator{T}"/>.
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static partial class ValidatorExtensions
    {
        #region " GetErrors "

        /// <summary>
        ///     Gets all errors if any.
        /// </summary>
        /// <typeparam name="T"> The type of the given value of the specified <paramref name="validator"/>. </typeparam>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}"/> that holds the value that has to
        ///     be checked.
        /// </param>
        /// <returns> The list of errors. </returns>
        public static IEnumerable<KeyValuePair<ViolationType, string>> GetErrors<T>(
            this IArgumentValidator<T> validator)
        {
            var val = validator as CollectOnErrorValidator<T>;
            if (val != null)
            {
                return val.ErrorHandler.Errors;
            }

            return Enumerable.Empty<KeyValuePair<ViolationType, string>>();
        }

        #endregion

        #region " IsValid "

        /// <summary>
        ///     Checks whether all conditions are met.
        /// </summary>
        /// <typeparam name="T"> The type of the given value of the specified <paramref name="validator"/>. </typeparam>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}"/> that holds the value that has to
        ///     be checked.
        /// </param>
        /// <returns>
        ///     <c> true </c> if all conditions was met; otherwise false.
        /// </returns>
        public static bool IsValid<T>(this IArgumentValidator<T> validator)
        {
            var val = validator as CollectOnErrorValidator<T>;
            if (val != null)
            {
                return !val.ErrorHandler.Errors.Any();
            }

            return false;
        }

        #endregion
    }
}