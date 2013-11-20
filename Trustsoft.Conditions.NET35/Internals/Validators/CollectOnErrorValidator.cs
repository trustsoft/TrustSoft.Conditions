//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="CollectOnErrorValidator.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    #region " Using Directives "

    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     Argument validator that does not throw just collect errors.
    /// </summary>
    /// <typeparam name="T"> The type of the argument value to validate. </typeparam>
    internal class CollectOnErrorValidator<T> : ArgumentValidatorBase<T>
    {
        private readonly IList<KeyValuePair<ViolationType, string>> errors =
            new List<KeyValuePair<ViolationType, string>>();

        /// <summary>
        ///     Initializes a new instance of the <see cref="CollectOnErrorValidator{T}"/> class.
        /// </summary>
        /// <param name="argument"> The argument. </param>
        public CollectOnErrorValidator(IArgument<T> argument)
            : base(argument, new CollectOnErrorHandler<T>())
        {
        }

        public override IEnumerable<KeyValuePair<ViolationType, string>> Errors
        {
            get
            {
                return this.errors;
            }
        }

        internal void CollectError(ViolationType violationType, string message)
        {
            this.errors.Add(new KeyValuePair<ViolationType, string>(violationType, message));
        }
    }
}