//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.String.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not empty.
        /// </exception>
        public static IArgumentValidator<string> IsEmpty(this IArgumentValidator<string> validator,
                                                         string conditionDescription = null)
        {
            if (!(validator.Argument.Value != null && validator.Argument.Value.Length == 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is not empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is empty.
        /// </exception>
        public static IArgumentValidator<string> IsNotEmpty(this IArgumentValidator<string> validator,
                                                            string conditionDescription = null)
        {
            var value = validator.Argument.Value;
            if (value != null && value.Length == 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is <c> null </c> or empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not <c> null </c> or empty.
        /// </exception>
        public static IArgumentValidator<string> IsNullOrEmpty(this IArgumentValidator<string> validator,
                                                               string conditionDescription = null)
        {
            if (!string.IsNullOrEmpty(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeNullOrEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is not <c> null </c> or empty.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> null </c> or empty.
        /// </exception>
        public static IArgumentValidator<string> IsNotNullOrEmpty(this IArgumentValidator<string> validator,
                                                                  string conditionDescription = null)
        {
            if (string.IsNullOrEmpty(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeNullOrEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is <c> null </c> or contains only whitespaces.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not <c> null </c> or contains only
        ///     non-whitespaces.
        /// </exception>
        public static IArgumentValidator<string> IsNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                    string conditionDescription = null)
        {
            if (!validator.Argument.Value.IsNullOrWhiteSpace())
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeNullOrWhiteSpace,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is not <c> null </c> or contains only non-whitespaces.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is <c> null </c> or contains only
        ///     whitespaces.
        /// </exception>
        public static IArgumentValidator<string> IsNotNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                       string conditionDescription = null)
        {
            if (validator.Argument.Value.IsNullOrWhiteSpace())
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeNullOrWhiteSpace,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}