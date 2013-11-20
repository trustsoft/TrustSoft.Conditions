//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ThrowOnErrorValidator.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    internal class ThrowOnErrorValidator<T> : ArgumentValidatorBase<T>
    {
        public ThrowOnErrorValidator(IArgument<T> argument)
            : base(argument, new ThrowOnErrorHandler<T>())
        {
        }
    }
}