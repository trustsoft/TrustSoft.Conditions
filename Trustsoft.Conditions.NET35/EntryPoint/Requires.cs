//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Requires.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;

    using Trustsoft.Conditions.Internals;

    #endregion

    /// <summary>
    ///     Entry point to methods that returns validator that will throw an exception, when some condition
    ///     is not met.
    /// </summary>
    public static class Requires
    {
        #region " Public Methods "

        /// <summary>
        ///     Creates the validator for specified argument that will throw an exception, when some condition
        ///     is not met.
        /// </summary>
        /// <typeparam name="T"> The type of argument value. </typeparam>
        /// <param name="value"> The value of the argument. </param>
        /// <param name="argumentName"> The name of the argument. </param>
        /// <returns> IArgumentValidator{T}. </returns>
        public static IArgumentValidator<T> That<T>(T value, string argumentName = null)
        {
            var argument = ArgumentFactory.Create(value, argumentName ?? "value");
            return new ThrowOnErrorValidator<T>(argument);
        }

        /// <summary>
        ///     Creates the validator for specified argument expression that will throw an exception,
        ///     when some condition is not met.
        /// </summary>
        /// <typeparam name="T"> The type of argument value. </typeparam>
        /// <param name="expression"> The argument expression. </param>
        /// <returns> IArgumentValidator{T}. </returns>
        public static IArgumentValidator<T> That<T>(Expression<Func<T>> expression)
        {
            var argument = ArgumentFactory.Create(expression);
            return new ThrowOnErrorValidator<T>(argument);
        }

        #endregion
    }
}