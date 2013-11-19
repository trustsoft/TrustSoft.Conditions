//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Type.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System;

    using Trustsoft.Conditions.Internals;

    #endregion

    public partial class ValidatorExtensions
    {
        public static IArgumentValidator<T> IsOfType<T>(this IArgumentValidator<T> validator,
                                                        Type type,
                                                        string conditionDescription = null) where T : class
        {
            T value = validator.Argument.Value;

            if (value != null && !type.IsInstanceOfType(value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeOfTypeX,
                                                    false,
                                                    type);
                validator.Error.Handle(msg);
            }

            return validator;
        }

        public static IArgumentValidator<T> IsNotOfType<T>(this IArgumentValidator<T> validator,
                                                           Type type,
                                                           string conditionDescription = null) where T : class
        {
            T value = validator.Argument.Value;

            if (value != null && type.IsInstanceOfType(value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeOfTypeX,
                                                    false,
                                                    type);
                validator.Error.Handle(msg);
            }

            return validator;
        }
    }
}