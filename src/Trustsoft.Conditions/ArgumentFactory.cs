//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Argument.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    using System;
    using System.Linq.Expressions;

    using Trustsoft.Conditions.Internals;

    /// <summary>
    ///     Provides ability to create <see cref="IArgument{T}" /> objects.
    /// </summary>
    public static class ArgumentFactory
    {
        #region " Public Methods "

        /// <summary>
        ///     Creates <see cref="IArgument{T}" /> object from specified value and name.
        /// </summary>
        /// <typeparam name="T"> The type of argument's value. </typeparam>
        /// <param name="argumentValue"> The value of the argument. </param>
        /// <param name="argumentName"> The name of the argument. </param>
        /// <returns> IArgument{T} object. </returns>
        public static IArgument<T> Create<T>(T argumentValue, string argumentName)
        {
            return new Argument<T>(argumentValue, argumentName);
        }

        /// <summary>
        ///     Creates <see cref="IArgument{T}" /> object from the specified expression.
        /// </summary>
        /// <typeparam name="T"> The type of argument's value. </typeparam>
        /// <param name="expression"> The argument expression. </param>
        /// <returns> IArgument{T} object. </returns>
        public static IArgument<T> Create<T>(Expression<Func<T>> expression)
        {
            return new ArgumentExpression<T>(expression);
        }

        #endregion
    }
}