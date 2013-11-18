//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="StringRes.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions
{
    #region " Using Directives "

    using System.Diagnostics;
    using System.Globalization;
    using System.Resources;

    #endregion

    /// <summary>
    ///     String Resource helper class.
    /// </summary>
    internal static class StringRes
    {
        internal const string TheActualValueIsX = "TheActualValueIsX";

        internal const string GuidShouldBeEmpty = "GuidShouldBeEmpty";
        internal const string GuidShouldNotBeEmpty = "GuidShouldNotBeEmpty";

        internal const string ValueShouldBeOfTypeX = "ValueShouldBeOfTypeX";
        internal const string ValueShouldNotBeOfTypeX = "ValueShouldNotBeOfTypeX";

        internal const string ValueShouldBeNull = "ValueShouldBeNull";
        internal const string ValueShouldNotBeNull = "ValueShouldNotBeNull";
        internal const string ValueShouldBeX = "ValueShouldBeX";
        internal const string ValueShouldBeSmallerThanX = "ValueShouldBeSmallerThanX";

        private static readonly ResourceManager resource;

        static StringRes()
        {
            resource = new ResourceManager(typeof(StringRes).Namespace + ".Resources.MessageStrings",
                                           typeof(StringRes).Assembly);
        }

        /// <summary>
        ///     Returns a string from the resource.
        /// </summary>
        /// <param name="resourceKey"> The resource key. </param>
        /// <returns> System.String. </returns>
        internal static string GetString(string resourceKey)
        {
            return resource.GetString(resourceKey);
        }

        /// <summary>
        ///     Returns a string from the resource and formats it with the given args in a culture-specific way.
        /// </summary>
        /// <param name="resourceKey"> The resource key. </param>
        /// <param name="args"> The arguments. </param>
        /// <returns> System.String. </returns>
        internal static string GetFormatedString(string resourceKey, params object[] args)
        {
            return GetStringInternal(resourceKey, args);
        }

        private static string GetStringInternal(string name, params object[] args)
        {
            string format = GetString(name);

            Debug.Assert(format != null, "resource.GetFormatedString() returned null for resourceKey=" + name);

            if (args == null)
            {
                return format;
            }

            return string.Format(CultureInfo.CurrentCulture, format, args);
        }
    }
}