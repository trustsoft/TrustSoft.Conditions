//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.IEnumerable{T}.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>21.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    using Trustsoft.Conditions.Internals;

    [SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
    public partial class ValidatorExtensions
    {
        #region " IsEmpty "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Collections.IEnumerable" /> is empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
        /// </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator" /> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator" /> is not empty.
        /// </exception>
        public static IArgumentValidator<T> IsEmpty<T>(this IArgumentValidator<T> validator,
                                                       string conditionDescription = null) where T : IEnumerable
        {
            if (!validator.Argument.Value.IsEmpty())
            {
                string msg = MessageBuilder.Combine(validator.Argument,
                                                    conditionDescription,
                                                    StringRes.CollectionShouldBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Collections.IEnumerable{T}" /> is empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
        /// </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator" /> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator" /> is not empty.
        /// </exception>
        public static IArgumentValidator<IEnumerable<T>> IsEmpty<T>(
            this IArgumentValidator<IEnumerable<T>> validator,
            string conditionDescription = null)
        {
            if (!validator.Argument.Value.IsEmpty())
            {
                string msg = MessageBuilder.Combine(validator.Argument,
                                                    conditionDescription,
                                                    StringRes.CollectionShouldBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsNotEmpty "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Collections.IEnumerable" /> is not empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
        /// </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator" /> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator" /> is empty.
        /// </exception>
        public static IArgumentValidator<T> IsNotEmpty<T>(this IArgumentValidator<T> validator,
                                                          string conditionDescription = null)
            where T : IEnumerable
        {
            if (!validator.Argument.Value.HasItems())
            {
                string msg = MessageBuilder.Combine(validator.Argument,
                                                    conditionDescription,
                                                    StringRes.CollectionShouldNotBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.Collections.IEnumerable{T}" /> is not empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator">
        ///     The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
        /// </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator" /> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator" /> is empty.
        /// </exception>
        public static IArgumentValidator<IEnumerable<T>> IsNotEmpty<T>(
            this IArgumentValidator<IEnumerable<T>> validator,
            string conditionDescription = null)
        {
            if (!validator.Argument.Value.HasItems())
            {
                string msg = MessageBuilder.Combine(validator.Argument,
                                                    conditionDescription,
                                                    StringRes.CollectionShouldNotBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion
    }
}