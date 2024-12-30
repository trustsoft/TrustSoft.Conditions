// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ValidatorExtensions.String.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>19.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

using Trustsoft.Conditions.Internals;

[SuppressMessage("ReSharper", "UnusedMethodReturnValue.Global")]
public static partial class ValidatorExtensions
{
    #region " Contains "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> contains <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to contain. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not contains <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> Contains(this IArgumentValidator<string> validator,
                                                      string part,
                                                      string? conditionDescription = null)
    {
        if (!validator.Argument.Value.Contains(part))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldContainX,
                                             false,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " DoesNotContain "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> does not contain <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to does not contain. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is contains <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> DoesNotContain(this IArgumentValidator<string> validator,
                                                            string part,
                                                            string? conditionDescription = null)
    {
        if (validator.Argument.Value.Contains(part))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotContainX,
                                             false,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " DoesNotEndWith "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> does not ends with <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to does not end with. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is ends with <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> DoesNotEndWith(this IArgumentValidator<string> validator,
                                                            string part,
                                                            string? conditionDescription = null)
    {
        if (validator.Argument.Value.EndsWith(part, StringComparison.Ordinal))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotEndWithX,
                                             true,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " DoesNotHaveLength "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> does not have length of <paramref name="length" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="length"> The string length to check for. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> has length of <paramref name="length" />.
    /// </exception>
    public static IArgumentValidator<string> DoesNotHaveLength(this IArgumentValidator<string> validator,
                                                               int length,
                                                               string? conditionDescription = null)
    {
        if (validator.Argument.Value.Length == length)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotBeXCharactersLong,
                                             false,
                                             length);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " DoesNotStartWith "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> does not starts with <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to does not start with. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> starts with <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> DoesNotStartWith(this IArgumentValidator<string> validator,
                                                              string part,
                                                              string? conditionDescription = null)
    {
        if (validator.Argument.Value.StartsWith(part, StringComparison.Ordinal))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotStartWithX,
                                             true,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " EndsWith "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> ends with <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to ends with. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not ends with <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> EndsWith(this IArgumentValidator<string> validator,
                                                      string part,
                                                      string? conditionDescription = null)
    {
        if (!validator.Argument.Value.EndsWith(part, StringComparison.Ordinal))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldEndWithX,
                                             true,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " HasLength "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> has length of <paramref name="length" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="length"> The string length to check for. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> has not length of <paramref name="length" />.
    /// </exception>
    public static IArgumentValidator<string> HasLength(this IArgumentValidator<string> validator,
                                                       int length,
                                                       string? conditionDescription = null)
    {
        if (validator.Argument.Value.Length != length)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeXCharactersLong,
                                             false,
                                             length);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsEmpty "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is empty.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value
    ///   of the specified <paramref name="validator" /> is not empty.
    /// </exception>
    public static IArgumentValidator<string> IsEmpty(this IArgumentValidator<string> validator,
                                                     string? conditionDescription = null)
    {
        var value = validator.Argument.Value;

        if (!(value != null && value.Length == 0))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeEmpty,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsLongerOrEqual "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is shorter or equal to <paramref name="minLength" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="minLength"> The maximum string length. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not shorter or equal to <paramref name="minLength" />.
    /// </exception>
    public static IArgumentValidator<string> IsLongerOrEqual(this IArgumentValidator<string> validator,
                                                             int minLength,
                                                             string? conditionDescription = null)
    {
        if (validator.Argument.Value.Length < minLength)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeLongerOrEqualToXCharacters,
                                             false,
                                             minLength);
            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsLongerThan "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is longer than <paramref name="minLength" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="minLength"> The maximum string length. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not longer than <paramref name="minLength" />.
    /// </exception>
    public static IArgumentValidator<string> IsLongerThan(this IArgumentValidator<string> validator,
                                                          int minLength,
                                                          string? conditionDescription = null)
    {
        if (!(validator.Argument.Value.Length > minLength))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeLongerThanXCharacters,
                                             false,
                                             minLength);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsMatch "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> matches the provided <paramref name="pattern" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="pattern"> The pattern to check for. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value
    ///   of the specified <paramref name="validator" /> is not match.
    /// </exception>
    public static IArgumentValidator<string> IsMatch(this IArgumentValidator<string> validator,
                                                     string pattern,
                                                     string? conditionDescription = null)
    {
        var regex = new Regex(pattern);

        if (!regex.IsMatch(validator.Argument.Value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldMatchPattern,
                                             true,
                                             pattern);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotEmpty "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is not empty.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of
    ///   the specified <paramref name="validator" /> is empty.
    /// </exception>
    public static IArgumentValidator<string> IsNotEmpty(this IArgumentValidator<string> validator,
                                                        string? conditionDescription = null)
    {
        var value = validator.Argument.Value;

        if (value != null && value.Length == 0)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotBeEmpty,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotMatch "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is not match
    ///   the provided regular expression <paramref name="pattern" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="pattern"> The pattern to check for. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of
    ///   the specified <paramref name="validator" /> is not match.
    /// </exception>
    public static IArgumentValidator<string> IsNotMatch(this IArgumentValidator<string> validator,
                                                        string pattern,
                                                        string? conditionDescription = null)
    {
        var regex = new Regex(pattern);

        if (regex.IsMatch(validator.Argument.Value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotMatchPattern,
                                             true,
                                             pattern);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotNullOrEmpty "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is not <see langword="null" /> or empty.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of
    ///   the specified <paramref name="validator" /> is <see langword="null" /> or empty.
    /// </exception>
    public static IArgumentValidator<string> IsNotNullOrEmpty(this IArgumentValidator<string> validator,
                                                              string? conditionDescription = null)
    {
        if (string.IsNullOrEmpty(validator.Argument.Value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotBeNullOrEmpty,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNotNullOrWhiteSpace "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is
    ///   not <see langword="null" /> or contains only non-whitespace characters.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is <see langword="null" /> or contains only whitespace characters.
    /// </exception>
    public static IArgumentValidator<string> IsNotNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                   string? conditionDescription = null)
    {
        if (validator.Argument.Value.IsNullOrWhiteSpace())
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldNotBeNullOrWhiteSpace,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNullOrEmpty "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is <see langword="null" /> or empty.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not <see langword="null" /> or empty.
    /// </exception>
    public static IArgumentValidator<string> IsNullOrEmpty(this IArgumentValidator<string> validator,
                                                           string? conditionDescription = null)
    {
        if (!string.IsNullOrEmpty(validator.Argument.Value))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeNullOrEmpty,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsNullOrWhiteSpace "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is
    ///   <see langword="null" /> or contains only whitespace characters.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified <paramref name="validator" />
    ///   is not <see langword="null" /> or contains only non-whitespace characters.
    /// </exception>
    public static IArgumentValidator<string> IsNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                string? conditionDescription = null)
    {
        if (!validator.Argument.Value.IsNullOrWhiteSpace())
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeNullOrWhiteSpace,
                                             false);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsShorterOrEqual "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is
    ///   shorter or equal to <paramref name="maxLength" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="maxLength"> The maximum string length. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not shorter or equal to <paramref name="maxLength" />.
    /// </exception>
    public static IArgumentValidator<string> IsShorterOrEqual(this IArgumentValidator<string> validator,
                                                              int maxLength,
                                                              string? conditionDescription = null)
    {
        if (validator.Argument.Value.Length > maxLength)
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeShorterOrEqualToXCharacters,
                                             false,
                                             maxLength);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " IsShorterThan "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> is shorter than <paramref name="maxLength" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="maxLength"> The maximum string length. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not shorter than <paramref name="maxLength" />.
    /// </exception>
    public static IArgumentValidator<string> IsShorterThan(this IArgumentValidator<string> validator,
                                                           int maxLength,
                                                           string? conditionDescription = null)
    {
        if (!(validator.Argument.Value.Length < maxLength))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldBeShorterThanXCharacters,
                                             false,
                                             maxLength);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion

    #region " StartsWith "

    /// <summary>
    ///   Checks whether the given <see cref="T:System.String" /> starts with <paramref name="part" />.
    /// </summary>
    /// <param name="validator">
    ///   The <see cref="IArgumentValidator{T}" /> that holds the value that has to be checked.
    /// </param>
    /// <param name="part"> The string to starts with. </param>
    /// <param name="conditionDescription"> The description of the condition that should hold. </param>
    /// <returns> The specified <paramref name="validator" /> instance. </returns>
    /// <exception cref="ArgumentException">
    ///   Throws or collects the error when the given value of the specified
    ///   <paramref name="validator" /> is not starts with <paramref name="part" />.
    /// </exception>
    public static IArgumentValidator<string> StartsWith(this IArgumentValidator<string> validator,
                                                        string part,
                                                        string? conditionDescription = null)
    {
        if (!validator.Argument.Value.StartsWith(part, StringComparison.Ordinal))
        {
            var msg = MessageBuilder.Combine(validator.Argument,
                                             conditionDescription,
                                             StringRes.StringShouldStartWithX,
                                             true,
                                             part);

            validator.ErrorHandler.Post(msg);
        }

        return validator;
    }

    #endregion
}