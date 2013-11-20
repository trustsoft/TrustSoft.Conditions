//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Class.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public partial class ValidatorExtensions
    {
        /// <summary>
        ///     Checks whether the given value is null. An exception is thrown otherwise.
        /// </summary>
        /// <typeparam name="T">
        ///     The type of the <see cref="IArgumentValidator{T}.Argument"> Value </see> of the specified
        ///     <paramref name="validator"/>.
        /// </typeparam>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription">
        ///     The description of the condition that should hold. The string may hold the placeholder '{0}' for
        ///     the <see cref="IArgumentValidator{T}.Argument"> argument name </see>.
        /// </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the <see cref="IArgumentValidator{T}.Argument"> Value </see> of the
        ///     specified <paramref name="validator"/> is not null, while the specified <paramref name="validator"/> is created
        ///     using the <see cref="Requires.That{T}(T,string)"> Requires </see> extension method.
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