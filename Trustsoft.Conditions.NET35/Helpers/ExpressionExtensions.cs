//------------------------Copyright © 2010-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ExpressionExtensions.cs" company="Trustsoft Ltd.">
//     Copyright © 2010-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.02.2016</date>
//------------------------Copyright © 2010-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;
    using System.Reflection;

    #endregion

    internal static class ExpressionExtensions
    {
        #region " GetName "

        public static string GetName<T>(this Expression<Func<T>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression != null)
            {
                return memberExpression.Member.Name;
            }
            throw new InvalidOperationException("Unable to get name from expression");
        }

        #endregion

        #region " GetValue "

        public static T GetValue<T>(this Expression<Func<T>> expression)
        {
            var memberExpression = (MemberExpression)expression.Body;
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
                value = expression.Compile().DynamicInvoke();
            }
            return (T)value;
        }

        #endregion
    }
}