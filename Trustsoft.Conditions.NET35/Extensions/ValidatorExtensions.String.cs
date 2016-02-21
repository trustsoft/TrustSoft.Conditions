//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.String.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2013</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;
    using System.Text.RegularExpressions;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        #region " Contains "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> contains <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to contain. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not contains <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> Contains(this IArgumentValidator<string> validator,
                                                          string part,
                                                          string conditionDescription = null)
        {
            if (!validator.Argument.Value.Contains(part))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldContainX,
                                                    false,
                                                    part);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> does not contain <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to does not contain. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is contains <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> DoesNotContain(this IArgumentValidator<string> validator,
                                                                string part,
                                                                string conditionDescription = null)
        {
            if (validator.Argument.Value.Contains(part))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotContainX,
                                                    false,
                                                    part);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsMatch "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> matches the provided <paramref name="pattern"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="pattern"> The pattern to check for. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not match.
        /// </exception>
        public static IArgumentValidator<string> IsMatch(this IArgumentValidator<string> validator,
                                                         string pattern,
                                                         string conditionDescription = null)
        {
            var regex = new Regex(pattern);
            if (!regex.IsMatch(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldMatchPattern,
                                                    true,
                                                    pattern);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is not match the provided <paramref name="pattern"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="pattern"> The pattern to check for. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not match.
        /// </exception>
        public static IArgumentValidator<string> IsNotMatch(this IArgumentValidator<string> validator,
                                                            string pattern,
                                                            string conditionDescription = null)
        {
            var regex = new Regex(pattern);
            if (regex.IsMatch(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotMatchPattern,
                                                    true,
                                                    pattern);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsEmpty "

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
            var value = validator.Argument.Value;
            if (!(value != null && value.Length == 0))
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

        #endregion

        #region " IsNullOrEmpty "

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

        #endregion

        #region " IsNullOrWhiteSpace "

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

        #endregion

        #region " StartsWith "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> starts with <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to starts with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not starts with
        ///     <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> StartsWith(this IArgumentValidator<string> validator,
                                                            string part,
                                                            string conditionDescription = null)
        {
            if (!validator.Argument.Value.StartsWith(part))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldStartWithX,
                                                    true,
                                                    part);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> does not starts with <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to does not starts with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> starts with
        ///     <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> DoesNotStartWith(this IArgumentValidator<string> validator,
                                                                  string part,
                                                                  string conditionDescription = null)
        {
            if (validator.Argument.Value.StartsWith(part))
            {
                string msg = MessageBuilder.Combine(validator,
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
        ///     Checks whether the given <see cref="T:System.String"/> ends with <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to ends with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not ends with
        ///     <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> EndsWith(this IArgumentValidator<string> validator,
                                                          string part,
                                                          string conditionDescription = null)
        {
            if (!validator.Argument.Value.EndsWith(part))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldEndWithX,
                                                    true,
                                                    part);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> does not ends with <paramref name="part"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="part"> The string to does not ends with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is ends with
        ///     <paramref name="part"/>.
        /// </exception>
        public static IArgumentValidator<string> DoesNotEndWith(this IArgumentValidator<string> validator,
                                                                string part,
                                                                string conditionDescription = null)
        {
            if (validator.Argument.Value.EndsWith(part))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotEndWithX,
                                                    true,
                                                    part);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsShorter "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is shorter than <paramref name="maxLength"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxLength"> The maximum string length. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not shorter than
        ///     <paramref name="maxLength"/>.
        /// </exception>
        public static IArgumentValidator<string> IsShorterThan(this IArgumentValidator<string> validator,
                                                               int maxLength,
                                                               string conditionDescription = null)
        {
            if (!(validator.Argument.Value.Length < maxLength))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeShorterThanXCharacters,
                                                    false,
                                                    maxLength);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is shorter or equal to <paramref name="maxLength"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxLength"> The maximum string length. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not shorter or equal to
        ///     <paramref name="maxLength"/>.
        /// </exception>
        public static IArgumentValidator<string> IsShorterOrEqual(this IArgumentValidator<string> validator,
                                                                  int maxLength,
                                                                  string conditionDescription = null)
        {
            if (validator.Argument.Value.Length > maxLength)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeShorterOrEqualToXCharacters,
                                                    false,
                                                    maxLength);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " IsLonger "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is longer than <paramref name="minLength"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minLength"> The maximum string length. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not longer than
        ///     <paramref name="minLength"/>.
        /// </exception>
        public static IArgumentValidator<string> IsLongerThan(this IArgumentValidator<string> validator,
                                                              int minLength,
                                                              string conditionDescription = null)
        {
            if (!(validator.Argument.Value.Length > minLength))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeLongerThanXCharacters,
                                                    false,
                                                    minLength);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> is shorter or equal to <paramref name="minLength"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minLength"> The maximum string length. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> is not shorter or equal to
        ///     <paramref name="minLength"/>.
        /// </exception>
        public static IArgumentValidator<string> IsLongerOrEqual(this IArgumentValidator<string> validator,
                                                                 int minLength,
                                                                 string conditionDescription = null)
        {
            if (validator.Argument.Value.Length < minLength)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeLongerOrEqualToXCharacters,
                                                    false,
                                                    minLength);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion

        #region " HasLength "

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> has length of <paramref name="length"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="length"> The string length to check for. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> has not length of
        ///     <paramref name="length"/>.
        /// </exception>
        public static IArgumentValidator<string> HasLength(this IArgumentValidator<string> validator,
                                                           int length,
                                                           string conditionDescription = null)
        {
            if (validator.Argument.Value.Length != length)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeXCharactersLong,
                                                    false,
                                                    length);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given <see cref="T:System.String"/> does not have length of <paramref name="length"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="length"> The string length to check for. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the given value of the specified <paramref name="validator"/> has length of <paramref name="length"/>.
        /// </exception>
        public static IArgumentValidator<string> DoesNotHaveLength(this IArgumentValidator<string> validator,
                                                                   int length,
                                                                   string conditionDescription = null)
        {
            if (validator.Argument.Value.Length == length)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeXCharactersLong,
                                                    false,
                                                    length);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        #endregion
    }
}