﻿//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IArgument{T}.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    /// <summary>
    ///     Represents an argument.
    /// </summary>
    /// <typeparam name="T"> The type of value of argument. </typeparam>
    public interface IArgument<T> : IFluentSyntax
    {
        #region " Properties "

        /// <summary>
        ///     Gets the name of the current <see cref="IArgument{T}"/> object.
        /// </summary>
        /// <value> The name of argument. </value>
        string Name { get; }

        /// <summary>
        ///     Gets the value of the current <see cref="IArgument{T}"/> object.
        /// </summary>
        /// <value> The value of argument. </value>
        T Value { get; }

        #endregion
    }
}