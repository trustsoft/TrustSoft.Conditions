﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="MessageBuilder.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

using System;

/// <summary>
///   Used to build messages for exceptions.
/// </summary>
internal static class MessageBuilder
{
    #region " Static Methods "

    internal static string Combine<T>(IArgument<T> argument,
                                      string? conditionDescription,
                                      string resourceKey,
                                      bool includeActualValue,
                                      params object[] args)
    {
        if (string.IsNullOrEmpty(conditionDescription))
        {
            var resource = StringRes.GetResourceByKey(resourceKey);
            var msg = InjectValues(argument, resource, args);

            if (includeActualValue)
            {
                msg = $"{msg}{Environment.NewLine}{argument.GetActualValueMessage()}";
            }

            return msg;
        }

        return InjectValues(argument, conditionDescription, args);
    }

    private static string GetActualValueMessage<T>(this IArgument<T> argument)
    {
        var value = argument.Value;

        // ReSharper disable once CompareNonConstrainedGenericWithNull
        if (value == null || value.GetType().FullName != value.ToString())
        {
            return StringRes.GetFormattedString(StringRes.TheActualValueIsX, value.MakeReadableString());
        }

        return string.Empty;
    }

    private static string InjectValues<T>(IArgument<T> argument, string format, params object[] args)
    {
        var result = format.Replace("{name}", argument.Name);
        result = result.Replace("{value}", argument.Value.MakeReadableString());
        int index = 1;

        foreach (var item in args)
        {
            var paramName = $"{{param{index}}}";
            result = result.Replace(paramName, item.MakeReadableString());
            index++;
        }

        if (!result.EndsWith(".", StringComparison.Ordinal))
        {
            result += ".";
        }

        return result;
    }

    /// <summary>
    ///   Makes the readable string.
    /// </summary>
    /// <param name="value"> The value. </param>
    private static string MakeReadableString(this object? value)
    {
        if (value == null)
        {
            return "<null>";
        }

        if (value is string || value is char)
        {
            return $"'{value}'";
        }

        return value.ToString();
    }

    #endregion
}