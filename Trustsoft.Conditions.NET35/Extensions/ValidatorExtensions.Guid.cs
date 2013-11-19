//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensions.Guid.cs" company="Trustsoft Ltd.">
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
        public static IArgumentValidator<Guid> IsEmpty(this IArgumentValidator<Guid> validator,
                                                       string conditionDescription = null)
        {
            if (!Guid.Empty.Equals(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator, conditionDescription, StringRes.GuidShouldBeEmpty, false);
                validator.Error.Handle(msg);
            }

            return validator;
        }

        public static IArgumentValidator<Guid> IsNotEmpty(this IArgumentValidator<Guid> validator,
                                                          string conditionDescription = null)
        {
            if (Guid.Empty.Equals(validator.Argument.Value))
            {
                string msg = MessageBuilder.Combine(validator,
                                                    conditionDescription,
                                                    StringRes.GuidShouldNotBeEmpty,
                                                    false);
                validator.Error.Handle(msg);
            }

            return validator;
        }
    }
}