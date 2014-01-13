//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Class.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        /// <summary>
        ///     Checks whether the given value is null. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of value of the argument contained in the specified <paramref name="validator"/>.
        /// </typeparam>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the argument`s value of the specified <paramref name="validator"/> is not null.
        /// </exception>
        public static IArgumentValidator<T> IsNull<T>(this IArgumentValidator<T> validator,
                                                      string conditionDescription = null) where T : class
        {
            if (validator.Argument.Value != null)
            {
                string msg = MessageBuilder.Combine(validator, conditionDescription, StringRes.ValueShouldBeNull, false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not null. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of value of the argument contained in the specified <paramref name="validator"/>.
        /// </typeparam>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the argument`s value of the specified <paramref name="validator"/> is null.
        /// </exception>
        public static IArgumentValidator<T> IsNotNull<T>(this IArgumentValidator<T> validator,
                                                         string conditionDescription = null) where T : class
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

        /// <summary>
        ///     Checks whether the given value is of specified <paramref name="type"/>. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T"> The type of value of the argument contained in the specified <paramref name="validator"/>. </typeparam>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="type"> The type. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the argument`s value of the <paramref name="validator"/> is not of specified <paramref name="type"/>.
        /// </exception>
        public static IArgumentValidator<T> IsOfType<T>(this IArgumentValidator<T> validator,
                                                        Type type,
                                                        string conditionDescription = null) where T : class
        {
            T value = validator.Argument.Value;

            if (value != null && !type.IsInstanceOfType(value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeOfTypeX,
                                                    false,
                                                    type);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not of specified <paramref name="type"/>. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T"> The type of value of the argument contained in the specified <paramref name="validator"/>. </typeparam>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="type"> The type. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the argument`s value of the <paramref name="validator"/> is of specified <paramref name="type"/>.
        /// </exception>
        public static IArgumentValidator<T> IsNotOfType<T>(this IArgumentValidator<T> validator,
                                                           Type type,
                                                           string conditionDescription = null) where T : class
        {
            T value = validator.Argument.Value;

            if (value != null && type.IsInstanceOfType(value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeOfTypeX,
                                                    false,
                                                    type);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}