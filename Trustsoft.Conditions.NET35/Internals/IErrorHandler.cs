//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    public interface IErrorHandler<T>
    {
        void Handle(ViolationType violationType, string message);

        void Handle(string message);

        IArgumentValidator<T> Validator { get; set; }
    }
}