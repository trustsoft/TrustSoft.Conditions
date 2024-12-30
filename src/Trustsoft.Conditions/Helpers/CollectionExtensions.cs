// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="CollectionExtensions.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>21.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;
using System.Collections;
using System.Collections.Generic;

internal static class CollectionExtensions
{
    #region " HasItems "

    /// <summary>
    ///   Determines whether a sequence contains any item.
    /// </summary>
    /// <param name="source"> The sequence of elements. </param>
    /// <returns> <see langword="false" /> if source is null or contains no items. </returns>
    public static bool HasItems(this IEnumerable source)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (source == null)
        {
            return false;
        }

        var enumerator = source.GetEnumerator();

        using (enumerator as IDisposable)
        {
            return enumerator.MoveNext();
        }
    }

    /// <summary>
    ///   Determines whether a sequence contains any item.
    /// </summary>
    /// <typeparam name="T"> Type of elements in <paramref name="source" /> sequence. </typeparam>
    /// <param name="source"> The sequence of elements. </param>
    /// <returns> <see langword="false" /> if source is null or contains no items. </returns>
    public static bool HasItems<T>(this IEnumerable<T> source)
    {
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (source == null)
        {
            return false;
        }

        using (var enumerator = source.GetEnumerator())
        {
            return enumerator.MoveNext();
        }
    }

    #endregion

    #region " IsEmpty "

    /// <summary>
    ///   Determines whether a sequence contains no element.
    /// </summary>
    /// <param name="source"> A sequence in which to locate a value. </param>
    /// <returns>
    ///   <see langword="true" /> if specified sequence contains no element; otherwise <see langword="false" />.
    /// </returns>
    public static bool IsEmpty(this IEnumerable source)
    {
        return !source.HasItems();
    }

    /// <summary>
    ///   Determines whether a sequence contains no element.
    /// </summary>
    /// <typeparam name="TSource"> The type of the elements of source. </typeparam>
    /// <param name="source"> A sequence in which to locate a value. </param>
    /// <returns>
    ///   <see langword="true" /> if specified sequence contains no element; otherwise <see langword="false" />.
    /// </returns>
    public static bool IsEmpty<TSource>(this IEnumerable<TSource> source)
    {
        return !source.HasItems();
    }

    #endregion
}