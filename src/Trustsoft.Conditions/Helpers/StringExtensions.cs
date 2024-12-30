// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="StringExtensions.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

#if NET35
using System.Linq;
#endif

internal static class StringExtensions
{
    #region " IsNullOrWhiteSpace "

    /// <summary>
    ///   Indicates whether a specified string is <see langword="null" />,
    ///   empty, or consists only of white-space characters.
    /// </summary>
    /// <param name="value"> The string to test. </param>
    /// <returns>
    ///   <see langword="true" /> if the specified <paramref name="value" /> is <see langword="null" />
    ///   or <see cref="string.Empty" />, or if <paramref name="value" /> consists exclusively of white-space characters.
    /// </returns>
    public static bool IsNullOrWhiteSpace(this string value)
    {
#if NET35
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (value == null)
        {
            return true;
        }

        return value.All(char.IsWhiteSpace);
#else
        return string.IsNullOrWhiteSpace(value);
#endif
    }

    #endregion
}