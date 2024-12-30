// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="CollectOnErrorValidator.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>20.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

namespace Trustsoft.Conditions.Internals;

/// <summary>
///   Argument validator that does not throw just collect errors.
/// </summary>
/// <typeparam name="T"> The type of the argument value to validate. </typeparam>
internal class CollectOnErrorValidator<T> : ArgumentValidatorBase<T, CollectOnErrorHandler<T>>
{
    /// <summary>
    ///   Initializes a new instance of the <see cref="CollectOnErrorValidator{T}" /> class.
    /// </summary>
    /// <param name="argument"> The argument. </param>
    public CollectOnErrorValidator(IArgument<T> argument)
            : base(argument, new CollectOnErrorHandler<T>())
    {
    }
}