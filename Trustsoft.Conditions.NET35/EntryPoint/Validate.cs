//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Validate.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;

    using Trustsoft.Conditions.Internals;

    #endregion

    /// <summary>
    ///     Entry point to methods that returns validator that will collect an exception, when some
    ///     condition
    ///     is not met.
    /// </summary>
    internal static class Validate
    {
        /// <summary>
        ///     Creates the validator for specified argument that will collect an exception, when some
        ///     condition
        ///     is not met.
        /// </summary>
        /// <typeparam name="T"> The type of argument argumentValue. </typeparam>
        /// <param name="value"> The value. </param>
        /// <param name="argumentName"> Name of the argument. </param>
        /// <returns> IArgumentValidator{T}. </returns>
        public static IArgumentValidator<T> That<T>(T value, string argumentName)
        {
            var argument = ArgumentFactory.Create(value, argumentName);
            return new CollectOnErrorValidator<T>(argument);
        }

        /// <summary>
        ///     Creates the validator for specified argument that will collect an exception, when some
        ///     condition
        ///     is not met.
        /// </summary>
        /// <typeparam name="T"> The type of argument argumentValue. </typeparam>
        /// <param name="expression"> The argument expression. </param>
        /// <returns> IArgumentValidator{T}. </returns>
        public static IArgumentValidator<T> That<T>(Expression<Func<T>> expression)
        {
            var argument = ArgumentFactory.Create(expression);
            return new CollectOnErrorValidator<T>(argument);
        }
    }
}