﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="Validate.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>20.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;
using System.Linq.Expressions;

using Trustsoft.Conditions.Internals;

/// <summary>
///   Provides methods for creating validator that will collect an exception,
///   when any of conditions is not held.
/// </summary>
public static class Validate
{
    /// <summary>
    ///   Creates the validator for specified argument that will collect an exception,
    ///   when any of conditions is not held.
    /// </summary>
    /// <typeparam name="T"> The type of argument argumentValue. </typeparam>
    /// <param name="value"> The value. </param>
    /// <param name="argumentName"> Name of the argument. </param>
    /// <returns> The argument validator that will collect exception on condition failing. </returns>
    public static IArgumentValidator<T> That<T>(T value, string argumentName)
    {
        var argument = ArgumentFactory.Create(value, argumentName);
        return new CollectOnErrorValidator<T>(argument);
    }

    /// <summary>
    ///   Creates the validator for specified argument that will collect an exception,
    ///   when any of conditions is not held.
    /// </summary>
    /// <typeparam name="T"> The type of argument argumentValue. </typeparam>
    /// <param name="expression"> The argument expression. </param>
    /// <returns> The argument validator that will collect exception on condition failing. </returns>
    public static IArgumentValidator<T> That<T>(Expression<Func<T>> expression)
    {
        var argument = ArgumentFactory.Create(expression);
        return new CollectOnErrorValidator<T>(argument);
    }
}