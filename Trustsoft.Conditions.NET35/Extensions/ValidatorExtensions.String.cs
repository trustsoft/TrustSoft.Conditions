//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.String.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using Trustsoft.Conditions.Internals;

    #endregion

    public static partial class ValidatorExtensions
    {
        public static IArgumentValidator<string> IsEmpty(this IArgumentValidator<string> validator,
                                                         string conditionDescription = null)
        {
            if (!(validator.Argument.Value != null && validator.Argument.Value.Length == 0))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        public static IArgumentValidator<string> IsNotEmpty(this IArgumentValidator<string> validator,
                                                            string conditionDescription = null)
        {
            var value = validator.Argument.Value;
            if (value != null && value.Length == 0)
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        public static IArgumentValidator<string> IsNullOrEmpty(this IArgumentValidator<string> validator,
                                                               string conditionDescription = null)
        {
            if (!string.IsNullOrEmpty(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeNullOrEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        public static IArgumentValidator<string> IsNotNullOrEmpty(this IArgumentValidator<string> validator,
                                                                  string conditionDescription = null)
        {
            if (string.IsNullOrEmpty(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeNullOrEmpty,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        public static IArgumentValidator<string> IsNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                    string conditionDescription = null)
        {
            if (!validator.Argument.Value.IsNullOrWhiteSpace())
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldBeNullOrWhiteSpace,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }

        public static IArgumentValidator<string> IsNotNullOrWhiteSpace(this IArgumentValidator<string> validator,
                                                                       string conditionDescription = null)
        {
            if (validator.Argument.Value.IsNullOrWhiteSpace())
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.StringShouldNotBeNullOrWhiteSpace,
                                                    false);
                validator.ErrorHandler.Post(msg);
            }

            return validator;
        }
    }
}