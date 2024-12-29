//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IFluentSyntax.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions;

using System;
using System.ComponentModel;

/// <summary>
///   Interface that is used to build fluent interfaces and
///   hide methods declared by <see cref="object" /> from IntelliSense.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public interface IFluentSyntax
{
    /// <summary>
    ///   Redeclaration that hides the <see cref="object.Equals(object)" /> method from IntelliSense.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    bool Equals(object obj);

    /// <summary>
    ///   Redeclaration that hides the <see cref="object.GetHashCode()" /> method from IntelliSense.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    int GetHashCode();

    /// <summary>
    ///   Redeclaration that hides the <see cref="object.GetType()" /> method from IntelliSense.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    Type GetType();

    /// <summary>
    ///   Redeclaration that hides the <see cref="object.ToString()" /> method from IntelliSense.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    string ToString();
}