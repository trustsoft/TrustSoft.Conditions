// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="Argument.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

internal class Argument<T> : IArgument<T>
{
    #region " Constructors "

    /// <summary>
    ///   Initializes a new instance of the <see cref="Argument{T}" /> class.
    /// </summary>
    public Argument(T value, string name)
    {
        this.Value = value;
        this.Name = name;
    }

    #endregion

    #region " Implementation of IArgument<T> "

    /// <summary>
    ///   Gets the name of argument.
    /// </summary>
    /// <value> The name of argument. </value>
    public string Name { get; }

    /// <summary>
    ///   Gets the value of argument.
    /// </summary>
    /// <value> The value of argument. </value>
    public T Value { get; }

    #endregion
}