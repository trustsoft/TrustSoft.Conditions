// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="IArgument{T}.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

/// <summary>
///   Represents an argument that contains name and value.
/// </summary>
/// <typeparam name="T"> The type of value of argument. </typeparam>
public interface IArgument<out T> : IFluentSyntax
{
    /// <summary>
    ///   Gets the name of an argument.
    /// </summary>
    /// <value> The name of argument. </value>
    string Name { get; }

    /// <summary>
    ///   Gets the value of an argument.
    /// </summary>
    /// <value> The value of argument. </value>
    T Value { get; } 
}