//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ArgumentExpression.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals;

using System;
using System.Linq.Expressions;

internal class ArgumentExpression<T> : IArgument<T>
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="ArgumentExpression{T}" /> class.
    /// </summary>
    public ArgumentExpression(Expression<Func<T>> expression)
    {
        this.Name = expression.GetName();
        this.Value = expression.GetValue();
    }

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
}