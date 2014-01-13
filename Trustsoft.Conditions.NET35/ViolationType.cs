//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ViolationType.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>12.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    /// <summary>
    ///     Defines the type of exception the validator should throw.
    /// </summary>
    public enum ViolationType
    {
        /// <summary>
        ///     Validator should throw the default exception.
        /// </summary>
        Default = 0,

        /// <summary>
        ///     Validator should throw an exception type appropriate for values that are out of range.
        /// </summary>
        OutOfRangeViolation = 1
    }
}