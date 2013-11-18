//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ArgumentExpression.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    #endregion

    internal class ArgumentExpression<T> : IArgument<T>
    {
        private readonly Expression<Func<T>> expression;

        /// <summary>
        ///     Gets the value of argument.
        /// </summary>
        /// <value> The value of argument. </value>
        public T Value
        {
            get
            {
                return GetValue(this.expression);
            }
        }

        /// <summary>
        ///     Gets the name of argument.
        /// </summary>
        /// <value> The name of argument. </value>
        public string Name
        {
            get
            {
                return GetName(this.expression);
            }
        }

        public ArgumentExpression(Expression<Func<T>> expression)
        {
            this.expression = expression;
        }

        private static string GetName(Expression<Func<T>> argument)
        {
            var memberExpression = argument.Body as MemberExpression;
            if (memberExpression != null)
            {
                return memberExpression.Member.Name;
            }
            throw new InvalidOperationException("Unable to get name from expression");
        }

        private static T GetValue(Expression<Func<T>> argument)
        {
            var memberExpression = (MemberExpression)argument.Body;
            object value;
            if (memberExpression.Expression.NodeType == ExpressionType.Constant)
            {
                var constantExpression = (ConstantExpression)memberExpression.Expression;
                if (memberExpression.Member.MemberType == MemberTypes.Property)
                {
                    value = ((PropertyInfo)memberExpression.Member).GetValue(constantExpression.Value, null);
                }
                else
                {
                    value = ((FieldInfo)memberExpression.Member).GetValue(constantExpression.Value);
                }
            }
            else
            {
                value = argument.Compile().DynamicInvoke();
            }
            return (T)value;
        }
    }
}