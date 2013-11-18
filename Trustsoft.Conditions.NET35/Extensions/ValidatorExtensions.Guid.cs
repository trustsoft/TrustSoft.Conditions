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
                string msg;
                if (string.IsNullOrEmpty(conditionDescription))
                {
                    var resource = StringRes.GetString(StringRes.GuidShouldBeEmpty);
                    msg = MessageBuilder.InjectValues(validator, resource);
                    //msg = string.Format("{0}{1}{2}", msg, Environment.NewLine, validator.GetActualValueMessage());
                }
                else
                {
                    msg = MessageBuilder.InjectValues(validator, conditionDescription);
                }
                validator.Error.Handle(msg);
            }

            return validator;
        }

        public static IArgumentValidator<Guid> IsNotEmpty(this IArgumentValidator<Guid> validator,
                                                          string conditionDescription = null)
        {
            if (Guid.Empty.Equals(validator.Argument.Value))
            {
                string msg;
                if (string.IsNullOrEmpty(conditionDescription))
                {
                    var resource = StringRes.GetString(StringRes.GuidShouldNotBeEmpty);
                    msg = MessageBuilder.InjectValues(validator, resource);
                    //msg = string.Format("{0}{1}{2}", msg, Environment.NewLine, validator.GetActualValueMessage());
                }
                else
                {
                    msg = MessageBuilder.InjectValues(validator, conditionDescription);
                }
                validator.Error.Handle(msg);
            }

            return validator;
        }
    }
}