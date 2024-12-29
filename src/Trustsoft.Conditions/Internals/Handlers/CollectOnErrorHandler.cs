//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="CollectOnErrorHandler.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Internals;

using System.Collections.Generic;

internal class CollectOnErrorHandler<T> : ErrorHandlerBase<T>
{
    #region " Fields "

    internal readonly IList<KeyValuePair<ViolationType, string>> Errors =
            new List<KeyValuePair<ViolationType, string>>();

    #endregion

    #region " Public Methods "

    /// <summary>
    ///   Posts the error of specified <paramref name="violationType"> type </paramref> to handler.
    /// </summary>
    /// <param name="violationType"> The type of violation. </param>
    /// <param name="message"> The error message. </param>
    public override void Post(ViolationType violationType, string message)
    {
        this.CollectError(violationType, message);
    }

    #endregion

    #region " Private Methods "

    private void CollectError(ViolationType violationType, string message)
    {
        this.Errors.Add(new KeyValuePair<ViolationType, string>(violationType, message));
    }

    #endregion
}