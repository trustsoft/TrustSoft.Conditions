// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="ErrorHandlerBase.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>18.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

internal abstract class ErrorHandlerBase<T> : IErrorHandler<T>
{
    #region " Implementation of IErrorHandler<T> "

    public IArgumentValidator<T> Validator { get; set; }

    public abstract void Post(ViolationType violationType, string message);

    public void Post(string message)
    {
        this.Post(ViolationType.Default, message);
    }

    #endregion
}