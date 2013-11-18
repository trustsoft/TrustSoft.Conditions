//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.cs" company="Trustsoft Ltd.">
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
        //private static string BuildFormatedMsg<T>(IArgumentValidator<T> validator, int maxValue)
        //{
        //    var actualValueMessage = validator.GetActualValueMessage();
        //    var resourceString = MessageBuilder.GetFormatedResourceString(validator,
        //                                                                  StringRes.ValueShouldBeSmallerThanX,
        //                                                                  validator.Argument.Name,
        //                                                                  maxValue);
        //    return string.Format("{0}{1}{2}", resourceString, Environment.NewLine, actualValueMessage);
        //}

        /// <summary>
        ///     Checks whether the given value is less than the specified <paramref name="maxValue"/>.
        ///     An exception is thrown otherwise.
        /// </summary>
        /// <param name="validator"> The <see cref="IArgumentValidator{T}"/> that holds the value that has to be checked. </param>
        /// <param name="maxValue"> The lowest invalid value. </param>
        /// <param name="conditionDescription">
        ///     The description of the condition that should hold. The string may hold the placeholder '{name}' for
        ///     the <see cref="IArgumentValidator{T}.Argument"> ArgumentName </see>.
        /// </param>
        /// <returns> The specified <paramref name="validator"/> instance. </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when the <see cref="IArgumentValidator{T}.Argument"> Value </see> of
        ///     the specified <paramref name="validator"/> is greater or equal to <paramref name="maxValue"/>.
        /// </exception>
        public static IArgumentValidator<int> IsLessThan(this IArgumentValidator<int> validator,
                                                         int maxValue,
                                                         string conditionDescription = null)
        {
            if (!(validator.Argument.Value < maxValue))
            {
                string msg;
                if (string.IsNullOrEmpty(conditionDescription))
                {
                    //var actualValueMessage = validator.GetActualValueMessage();
                    //var resourceString = MessageBuilder.GetFormatedResourceString(validator,
                    //                                                              StringRes.ValueShouldBeSmallerThanX,
                    //                                                              maxValue);
                    //msg = string.Format("{0}{1}{2}", resourceString, Environment.NewLine, actualValueMessage);
                    var resource = StringRes.GetString(StringRes.ValueShouldBeSmallerThanX);
                    msg = MessageBuilder.InjectValues(validator, resource, maxValue);
                    msg = string.Format("{0}{1}{2}", msg, Environment.NewLine, validator.GetActualValueMessage());
                }
                else
                {
                    msg = MessageBuilder.InjectValues(validator, conditionDescription, maxValue);
                    //msg = string.Format(conditionDescription,
                    //                    validator.Argument.Name,
                    //                    validator.Argument.Value,
                    //                    maxValue);
                }
                validator.Error.Handle(ViolationType.OutOfRangeViolation, msg);

                //var resourceString = StringRes.GetString(StringRes.ValueShouldBeSmallerThanX);
                //string condition = ErrorMessageBuilder.GetFormatedString(resourceString,
                //                                                    validator.Argument.Name,
                //                                                    maxValue.MakeReadableString());

                //string message = conditionDescription == null
                //    ? condition
                //    : ErrorMessageBuilder.GetConditionMessage(validator.Argument, conditionDescription);

                //string additionalMessage = validator.Argument.GetActualValueMessage();

                //validator.ErrorHandler.Handle(message, additionalMessage, ViolationType.OutOfRangeViolation);
                //ThrowHelper.ValueShouldBeSmallerThan(validator, maxValue, conditionDescription);
            }

            return validator;
        }
    }
}