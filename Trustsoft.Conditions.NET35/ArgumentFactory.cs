//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Argument.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;

    using Trustsoft.Conditions.Internals;

    #endregion

    public static class ArgumentFactory
    {
        public static IArgument<T> Create<T>(T argumentValue, string argumentName = null)
        {
            return new Argument<T>(argumentValue, argumentName);
        }

        public static IArgument<T> Create<T>(Expression<Func<T>> expression)
        {
            return new ArgumentExpression<T>(expression);
        }
    }
}