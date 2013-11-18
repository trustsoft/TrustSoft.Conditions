//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IArgumentValidator.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using Trustsoft.Conditions.Internals;

    #endregion

    public interface IArgumentValidator<T>
    {
        IArgument<T> Argument { get; }

        IErrorHandler<T> Error { get; }
    }
}