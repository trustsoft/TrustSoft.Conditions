//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Boolean.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>12.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions;

using System;

using Trustsoft.Conditions.Internals;

public static partial class ValidatorExtensions
{
    #region " IsFalse "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.Boolean" /> is <see langword="false" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is <see langword="true" />.
    /// </exception>
    public static IArgumentValidator<bool> IsFalse(this IArgumentValidator<bool> validator,
                                                   string? conditionDescription = null)
    {
        return IsValid(validator, false, conditionDescription);
    }

    /// <summary>
    ///   Checks whether the given <see cref="T:System.Boolean" /> is <see langword="false" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is <see langword="true" />.
    /// </exception>
    public static IArgumentValidator<bool?> IsFalse(this IArgumentValidator<bool?> validator,
                                                    string? conditionDescription = null)
    {
        return IsValid(validator, false, conditionDescription);
    }

    #endregion

    #region " IsTrue "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.Boolean" /> is <see langword="true" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is <see langword="false" />.
    /// </exception>
    public static IArgumentValidator<bool> IsTrue(this IArgumentValidator<bool> validator,
                                                  string? conditionDescription = null)
    {
        return IsValid(validator, true, conditionDescription);
    }

    /// <summary>
    ///   Checks whether the given <see cref="T:System.Boolean" /> is <see langword="true" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is <see langword="false" />.
    /// </exception>
    public static IArgumentValidator<bool?> IsTrue(this IArgumentValidator<bool?> validator,
                                                   string? conditionDescription = null)
    {
        return IsValid(validator, true, conditionDescription);
    }

    #endregion

    #region " IsValid "

    private static IArgumentValidator<bool> IsValid(IArgumentValidator<bool> validator,
                                                    bool expected,
                                                    string? conditionDescription)
    {
        if (validator.Argument.Value != expected)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldBeX,
                                             false,
                                             expected);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    private static IArgumentValidator<bool?> IsValid(IArgumentValidator<bool?> validator,
                                                     bool? expected,
                                                     string? conditionDescription)
    {
        if (validator.Argument.Value != expected)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.ValueShouldBeX,
                                             false,
                                             expected!);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}