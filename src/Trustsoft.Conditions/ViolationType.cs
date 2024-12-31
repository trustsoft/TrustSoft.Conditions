// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ViolationType.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>12.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

/// <summary>
///   Defines the type of exception that <see cref="IArgumentValidator{T}"/>> should throw or collect.
/// </summary>
public enum ViolationType
{
    /// <summary>
    ///   Validator should throw the default exception.
    /// </summary>
    Default = 0,

    /// <summary>
    ///   Validator should throw an exception type appropriate for values that are out of range.
    /// </summary>
    OutOfRange = 1
}