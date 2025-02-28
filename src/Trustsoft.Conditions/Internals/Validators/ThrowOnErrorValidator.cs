﻿// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ThrowOnErrorValidator.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

/// <summary>
///   Argument validator that throws on error.
/// </summary>
/// <typeparam name="T"> The type of the argument value to validate. </typeparam>
internal class ThrowOnErrorValidator<T> : ArgumentValidatorBase<T, ThrowOnErrorHandler<T>>
{
    public ThrowOnErrorValidator(IArgument<T> argument)
            : base(argument, new ThrowOnErrorHandler<T>())
    {
    }
}