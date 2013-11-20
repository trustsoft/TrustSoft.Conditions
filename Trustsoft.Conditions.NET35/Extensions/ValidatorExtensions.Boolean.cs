//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Boolean.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>12.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using Trustsoft.Conditions.Internals;

    #endregion

    public partial class ValidatorExtensions
    {
        public static IArgumentValidator<bool> IsTrue(this IArgumentValidator<bool> validator,
                                                      string conditionDescription = null)
        {
            return IsValid(validator, true, conditionDescription);
        }

        public static IArgumentValidator<bool> IsFalse(this IArgumentValidator<bool> validator,
                                                       string conditionDescription = null)
        {
            return IsValid(validator, false, conditionDescription);
        }

        private static IArgumentValidator<bool> IsValid(IArgumentValidator<bool> validator,
                                                        bool expected,
                                                        string conditionDescription)
        {
            if (validator.Argument.Value != expected)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.ValueShouldBeX,
                                                    false,
                                                    expected);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}