//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Nullable.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using Trustsoft.Conditions.Internals;

    #endregion

    public partial class ValidatorExtensions
    {
        public static IArgumentValidator<T?> IsNull<T>(this IArgumentValidator<T?> validator,
                                                       string conditionDescription = null) where T : struct
        {
            if (validator.Argument.Value != null)
            {
                string msg = MessageBuilder.Combine(validator, conditionDescription, StringRes.ValueShouldBeNull, false);
                validator.Error.Handle(msg);
            }

            return validator;
        }

        public static IArgumentValidator<T?> IsNotNull<T>(this IArgumentValidator<T?> validator,
                                                          string conditionDescription = null) where T : struct
        {
            if (validator.Argument.Value == null)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldNotBeNull,
                                                    false);
                validator.Error.Handle(msg);
            }

            return validator;
        }
    }
}