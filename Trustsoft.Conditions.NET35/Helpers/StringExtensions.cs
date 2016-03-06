//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="StringHelpers.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
#if NET35

    #region " Using Directives "

    using System.Linq;

    #endregion

#endif

    internal static class StringExtensions
    {
        #region " IsNullOrWhiteSpace "

        /// <summary>
        ///     Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="value"> The string to test. </param>
        /// <returns>
        ///     true if the <paramref name="value"/> parameter is null or <see cref="string.Empty"/>,
        ///     or if <paramref name="value"/> consists exclusively of white-space characters.
        /// </returns>
        public static bool IsNullOrWhiteSpace(this string value)
        {
#if NET35
            if (value == null)
            {
                return true;
            }

            return value.All(char.IsWhiteSpace);
#else
            return string.IsNullOrWhiteSpace(value);
#endif
        }

        #endregion
    }
}