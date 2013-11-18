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

            if (value != null)
            {
                bool valueIsValid = type.IsInstanceOfType(value);

                if (!valueIsValid)
                {
                    string msg;
                    if (string.IsNullOrEmpty(conditionDescription))
                    {
                        var resource = StringRes.GetString(StringRes.ValueShouldBeOfTypeX);
                        msg = MessageBuilder.InjectValues(validator, resource, type);
                    }
                    else
                    {
                        msg = MessageBuilder.InjectValues(validator, conditionDescription, type);
                    }
                    validator.Error.Handle(msg);
                }
            }

            return validator;
        }

        public static IArgumentValidator<T> IsNotOfType<T>(this IArgumentValidator<T> validator,
                                                           Type type,
                                                           string conditionDescription = null) where T : class
        {
            T value = validator.Argument.Value;

            if (value != null)
            {
                bool valueIsInvalid = type.IsInstanceOfType(value);

                if (valueIsInvalid)
                {
                    string msg;
                    if (string.IsNullOrEmpty(conditionDescription))
                    {
                        var resource = StringRes.GetString(StringRes.ValueShouldNotBeOfTypeX);
                        msg = MessageBuilder.InjectValues(validator, resource, type);
                    }
                    else
                    {
                        msg = MessageBuilder.InjectValues(validator, conditionDescription, type);
                    }
                    validator.Error.Handle(msg);
                }
            }

            return validator;
        }
    }
}