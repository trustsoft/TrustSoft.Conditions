//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="CollectOnErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals
{
    using Trustsoft.Conditions;

    internal class CollectOnErrorHandler<T> : ErrorHandlerBase<T>
    {
        /// <summary>
        ///     Posts the error of specified <paramref name="violationType"> type </paramref> to handler.
        /// </summary>
        /// <param name="violationType"> The type of violation. </param>
        /// <param name="message"> The error message. </param>
        public override void Post(ViolationType violationType, string message)
        {
            ((CollectOnErrorValidator<T>)this.Validator).CollectError(violationType, message);
        }
    }
}