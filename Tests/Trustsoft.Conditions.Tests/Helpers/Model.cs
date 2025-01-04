// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="Model.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Tests.Helpers;

using System;

internal class Model : ModelBase, IComparable<Model>
{
    #region " Public Properties "

    public int Number { get; private set; }

    #endregion

    #region " Constructors / Destructors "

    /// <summary>
    ///   Initializes a new instance of the <see cref="Model" /> class.
    /// </summary>
    public Model(int number)
    {
        this.Number = number;
    }

    public Model()
    {
    }

    #endregion

    #region " Implementation of IComparable<Model> "

    /// <summary>
    ///   Compares the current object with another object of the same type.
    /// </summary>
    /// <returns>
    ///   A 32-bit signed integer that indicates the relative order of the objects being compared. The return value
    ///   has the
    ///   following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" />
    ///   parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater
    ///   than
    ///   <paramref name="other" />.
    /// </returns>
    /// <param name="other"> An object to compare with this object. </param>
    public int CompareTo(Model other)
    {
        return this.Number.CompareTo(other.Number);
    }

    #endregion
}