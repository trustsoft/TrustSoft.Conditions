//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IArgument{T}.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    public interface IArgument<T>
    {
        /// <summary>
        ///     Gets the value of argument.
        /// </summary>
        /// <value> The value of argument. </value>
        T Value { get; }

        /// <summary>
        ///     Gets the name of argument.
        /// </summary>
        /// <value> The name of argument. </value>
        string Name { get; }
    }
}