//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Int32.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
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
        ///     Checks whether the given value is less than zero.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater or equal to zero.
        /// </exception>
        public static IArgumentValidator<int> IsNegative(this IArgumentValidator<int> validator,
                                                         string conditionDescription = null)
        {
            return validator.IsLessThan(0, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given value is not less than zero or equal to zero.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to zero.
        /// </exception>
        public static IArgumentValidator<int> IsNotNegative(this IArgumentValidator<int> validator,
                                                            string conditionDescription = null)
        {
            return validator.IsNotLessThan(0, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given value is greater than zero.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to zero.
        /// </exception>
        public static IArgumentValidator<int> IsPositive(this IArgumentValidator<int> validator,
                                                         string conditionDescription = null)
        {
            return validator.IsGreaterThan(0, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given value is smaller or equal to zero.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater than zero.
        /// </exception>
        public static IArgumentValidator<int> IsNotPositive(this IArgumentValidator<int> validator,
                                                            string conditionDescription = null)
        {
            return validator.IsLessOrEqual(0, conditionDescription);
        }

        /// <summary>
        ///     Checks whether the given value is between <paramref name="minValue"/> and
        ///     <paramref name="maxValue"/> (including those values). An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="maxValue"> The highest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is not in the specified range.
        /// </exception>
        public static IArgumentValidator<int> IsInRange(this IArgumentValidator<int> validator,
                                                        int minValue,
                                                        int maxValue,
                                                        string conditionDescription = null)
        {
            int value = validator.Argument.Value;

            if (!(value >= minValue && value <= maxValue))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeBetweenXAndY,
                                                    true,
                                                    minValue,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not between <paramref name="minValue"/> and
        ///     <paramref name="maxValue"/> (including those values). An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest invalid value. </param>
        /// <param name="maxValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is in the specified range.
        /// </exception>
        public static IArgumentValidator<int> IsNotInRange(this IArgumentValidator<int> validator,
                                                           int minValue,
                                                           int maxValue,
                                                           string conditionDescription = null)
        {
            int value = validator.Argument.Value;

            if (value >= minValue && value <= maxValue)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeBetweenXAndY,
                                                    true,
                                                    minValue,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is greater than the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to
        ///     <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsGreaterThan(this IArgumentValidator<int> validator,
                                                            int minValue,
                                                            string conditionDescription = null)
        {
            if (!(validator.Argument.Value > minValue))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeGreaterThanX,
                                                    true,
                                                    minValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not greater than the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater than <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsNotGreaterThan(this IArgumentValidator<int> validator,
                                                               int maxValue,
                                                               string conditionDescription = null)
        {
            if (validator.Argument.Value > maxValue)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeGreaterThanX,
                                                    true,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is greater or equal to the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller than <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsGreaterOrEqual(this IArgumentValidator<int> validator,
                                                               int minValue,
                                                               string conditionDescription = null)
        {
            if (!(validator.Argument.Value >= minValue))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeGreaterThanOrEqualToX,
                                                    true,
                                                    minValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not greater or equal to the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/>
        ///     is greater or equal to <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsNotGreaterOrEqual(this IArgumentValidator<int> validator,
                                                                  int maxValue,
                                                                  string conditionDescription = null)
        {
            if (validator.Argument.Value >= maxValue)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeGreaterThanOrEqualToX,
                                                    true,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is less than the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/>
        ///     is greater or equal to <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsLessThan(this IArgumentValidator<int> validator,
                                                         int maxValue,
                                                         string conditionDescription = null)
        {
            if (!(validator.Argument.Value < maxValue))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeSmallerThanX,
                                                    true,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not less than the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The lowest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller than <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsNotLessThan(this IArgumentValidator<int> validator,
                                                            int minValue,
                                                            string conditionDescription = null)
        {
            if (validator.Argument.Value < minValue)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeSmallerThanX,
                                                    true,
                                                    minValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is smaller or equal to the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The highest valid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is greater than <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsLessOrEqual(this IArgumentValidator<int> validator,
                                                            int maxValue,
                                                            string conditionDescription = null)
        {
            if (!(validator.Argument.Value <= maxValue))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeSmallerThanOrEqualToX,
                                                    true,
                                                    maxValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is not smaller or equal to the specified <paramref name="minValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="minValue"> The highest invalid value. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is smaller or equal to
        ///     <paramref name="minValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsNotLessOrEqual(this IArgumentValidator<int> validator,
                                                               int minValue,
                                                               string conditionDescription = null)
        {
            if (validator.Argument.Value <= minValue)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeSmallerThanOrEqualToX,
                                                    true,
                                                    minValue);
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is equal to the specified <paramref name="value"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="value"> The valid value to compare with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is not equal to <paramref name="value"/>.
        /// </exception>
        public static IArgumentValidator<int> IsEqualTo(this IArgumentValidator<int> validator,
                                                        int value,
                                                        string conditionDescription = null)
        {
            if (validator.Argument.Value != value)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeEqualToX,
                                                    true,
                                                    value);
                validator.Error.Handle(msg);
            }

            return validator;
        }

        /// <summary>
        ///     Checks whether the given value is unequal to the specified <paramref name="value"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="value"> The invalid value to compare with. </param>
        /// <param name="conditionDescription"> The description of the condition that should hold. </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentException">
        ///     Thrown when the value of the specified <paramref name="validator"/> is equal to <paramref name="value"/>.
        /// </exception>
        public static IArgumentValidator<int> IsNotEqualTo(this IArgumentValidator<int> validator,
                                                           int value,
                                                           string conditionDescription = null)
        {
            if (validator.Argument.Value == value)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeUnequalToX,
                                                    true,
                                                    value);
                validator.Error.Handle(msg);
            }

            return validator;
        }
    }
}