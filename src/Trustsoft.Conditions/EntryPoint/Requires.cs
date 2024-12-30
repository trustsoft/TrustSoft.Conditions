﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="Requires.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;
using System.Linq.Expressions;

using Trustsoft.Conditions.Internals;

/// <summary>
///   Represents methods that return argument validator for further validations.
/// </summary>
/// <remars> It will throw an exception, when any of conditions is not met. </remars>
public static class Requires
{
    /// <summary>
    ///   Creates the validator for specified <paramref name="value"/>
    ///   that will throw an exception, when any of conditions is not met.
    /// </summary>
    /// <typeparam name="T"> The type of argument value. </typeparam>
    /// <param name="value"> The value of the argument. </param>
    /// <param name="argumentName"> The name of the argument. </param>
    /// <returns> IArgumentValidator{T}. </returns>
    public static IArgumentValidator<T> That<T>(T value, string? argumentName = null)
    {
        var argument = ArgumentFactory.Create(value, argumentName ?? nameof(value));
        return new ThrowOnErrorValidator<T>(argument);
    }

    /// <summary>
    ///   Creates the validator for specified argument expression
    ///   that will throw an exception, when any of conditions is not met.
    /// </summary>
    /// <typeparam name="T"> The type of argument value. </typeparam>
    /// <param name="expression"> The argument expression. </param>
    /// <returns> IArgumentValidator{T}. </returns>
    public static IArgumentValidator<T> That<T>(Expression<Func<T>> expression)
    {
        var argument = ArgumentFactory.Create(expression);
        return new ThrowOnErrorValidator<T>(argument);
    }
}