//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Nullable.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions;

using System;
using System.Diagnostics.CodeAnalysis;

using Trustsoft.Conditions.Internals;

[SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
public static partial class ValidatorExtensions
{
    #region " IsNotNull "

    /// <summary>
    ///   Checks whether the given <see cref="System.Nullable{T}" /> is not <see langword="null" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of
    ///   the specified <paramref name="validator" /> is <see langword="null" />.
    /// </exception>
    public static IArgumentValidator<T?> IsNotNull<T>(this IArgumentValidator<T?> validator,
                                                      string? conditionDescription = null)
            where T : struct
    {
        if (validator.Argument.Value == null)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldNotBeNull,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNull "

    /// <summary>
    ///   Checks whether the given <see cref="System.Nullable{T}" /> is <see langword="null" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of
    ///   the specified <paramref name="validator" /> is not <see langword="null" />.
    /// </exception>
    public static IArgumentValidator<T?> IsNull<T>(this IArgumentValidator<T?> validator,
                                                   string? conditionDescription = null)
            where T : struct
    {
        if (validator.Argument.Value != null)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldBeNull,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}