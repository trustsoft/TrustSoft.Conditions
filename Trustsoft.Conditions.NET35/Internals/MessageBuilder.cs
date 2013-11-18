//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="MessageBuilder.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System.Collections.Generic;

    #endregion

    internal static class MessageBuilder
    {
        /// <summary>
        ///     Makes the string readable.
        /// </summary>
        /// <param name="value"> The value. </param>
        /// <returns> System.String. </returns>
        internal static string MakeReadableString(this object value)
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

        internal static string GetActualValueMessage<T>(this IArgumentValidator<T> validator)
        {
            var value = validator.Argument.Value;
            var name = validator.Argument.Name;

            // ReSharper disable CompareNonConstrainedGenericWithNull
            if (value == null || value.GetType().FullName != value.ToString())
            {
                return StringRes.GetFormatedString(StringRes.TheActualValueIsX, name, value.MakeReadableString());
            }
            // ReSharper restore CompareNonConstrainedGenericWithNull

            return null;
        }

        internal static string GetFormatedResourceString<T>(IArgumentValidator<T> validator,
                                                            string resourceName,
                                                            params object[] args)
        {
            var resource = StringRes.GetString(resourceName);
            List<object> allArgs = new List<object>();
            allArgs.Add(validator.Argument.Name);
            allArgs.Add(validator.Argument.Value);
            allArgs.AddRange(args);
            return string.Format(resource, allArgs);
            //return string.Format(result, args);
            //return StringRes.GetFormatedString(resourceName, args);
        }

        internal static string InjectValues<T>(IArgumentValidator<T> validator, string format, params object[] args)
        {
            var result = format.Replace("{name}", validator.Argument.Name);
            result = result.Replace("{value}", validator.Argument.Value.MakeReadableString());
            int index = 1;
            foreach (var item in args)
            {
                var paramName = "{param" + index + "}";
                result = result.Replace(paramName, item.MakeReadableString());
                index++;
            }

            return result;
        }
    }
}