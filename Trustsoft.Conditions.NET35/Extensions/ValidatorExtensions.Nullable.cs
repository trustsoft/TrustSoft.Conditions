//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Nullable.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        /// <summary>
        ///     Checks whether the given <see cref="System.Nullable{T}"/> is <c> null </c>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not <c> null </c>.
        /// </exception>
        public static IArgumentValidator<T?> IsNull<T>(this IArgumentValidator<T?> validator,
                                                       string conditionDescription = null) where T : struct
        {
            if (validator.Argument.Value != null)
            {
                string msg = MessageBuilder.Combine(validator, conditionDescription, StringRes.ValueShouldBeNull, false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="System.Nullable{T}"/> is not <c> null </c>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> null </c>.
        /// </exception>
        public static IArgumentValidator<T?> IsNotNull<T>(this IArgumentValidator<T?> validator,
                                                          string conditionDescription = null) where T : struct
        {
            if (validator.Argument.Value == null)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeNull,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}