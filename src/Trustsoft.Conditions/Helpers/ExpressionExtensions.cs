// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ExpressionExtensions.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>20.02.2016</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions;

using System;
using System.Linq.Expressions;
using System.Reflection;

internal static class ExpressionExtensions
{
    #region " GetName "

    public static string GetName<T>(this Expression<Func<T>> expression)
    {
        if (expression.Body is MemberExpression memberExpression)
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

        if (memberExpression.Expression != null && memberExpression.Expression.NodeType == ExpressionType.Constant)
        {
            var constantExpression = (ConstantExpression)memberExpression.Expression;
            value = memberExpression.Member.MemberType == MemberTypes.Property
                    ? ((PropertyInfo)memberExpression.Member).GetValue(constantExpression.Value, null)
                    : ((FieldInfo)memberExpression.Member).GetValue(constantExpression.Value);
        }
        else
        {
            value = expression.Compile().DynamicInvoke();
        }

        return (T)value;
    }

    #endregion
}