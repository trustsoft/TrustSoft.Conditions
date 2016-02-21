//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="MessageBuilder.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System;

    #endregion

    /// <summary>
    ///     Used to build messages for exceptions.
    /// </summary>
    internal static class MessageBuilder
    {
        /// <summary>
        ///     Makes the string readable.
        /// </summary>
        /// <param name="value"> The value. </param>
        /// <returns> System.String. </returns>
        private static string MakeReadableString(this object value)
        {
            if (value == null)
            {
                return "null";
            }

            if (value is string || value is char)
            {
                return string.Format("'{0}'", value);
            }

            return value.ToString();
        }

        private static string GetActualValueMessage<T>(this IArgumentValidator<T> validator)
        {
            var value = validator.Argument.Value;

            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (value == null || value.GetType().FullName != value.ToString())
            {
                return StringRes.GetFormatedString(StringRes.TheActualValueIsX, value.MakeReadableString());
            }
            // ReSharper restore CompareNonConstrainedGenericWithNull

            return string.Empty;
        }

        private static string InjectValues<T>(IArgumentValidator<T> validator, string format, params object[] args)
        {
            var result = format.Replace("{name}", validator.Argument.Name);
            result = result.Replace("{value}", validator.Argument.Value.MakeReadableString());
            int index = 1;
            foreach (var item in args)
            {
                var paramName = string.Format("{{param{0}}}", index);
                result = result.Replace(paramName, item.MakeReadableString());
                index++;
            }
            if (!result.EndsWith("."))
            {
                result += ".";
            }

            return result;
        }

        internal static string Combine<T>(IArgumentValidator<T> validator,
                                          string conditionDescription,
                                          string resourceKey,
                                          bool includeActualValue,
                                          params object[] args)
        {
            string msg;
            if (string.IsNullOrEmpty(conditionDescription))
            {
                var resource = StringRes.GetString(resourceKey);
                msg = InjectValues(validator, resource, args);
                if (includeActualValue)
                {
                    msg = string.Format("{0}{1}{2}", msg, Environment.NewLine, validator.GetActualValueMessage());
                }
            }
            else
            {
                msg = InjectValues(validator, conditionDescription, args);
            }
            return msg;
        }
    }
}