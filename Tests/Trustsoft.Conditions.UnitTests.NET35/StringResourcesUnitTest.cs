//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="UnitTest1.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>10.11.2013</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class StringResourcesUnitTest
    {
        private static Type srType;

        private static IEnumerable<FieldInfo> GetStringFields()
        {
            Assert.IsNotNull(srType, "The type StringRes could not be found in the Trustsoft.Conditions assembly.");

            const BindingFlags fieldFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;

            var resourceFields = from field in srType.GetFields(fieldFlags)
                                 where field.FieldType == typeof(string)
                                 select field;

            // ReSharper disable PossibleMultipleEnumeration
            Assert.AreNotEqual(0, resourceFields.Count(), "The fields of StringRes could not be retrieved.");

            return resourceFields;
            // ReSharper restore PossibleMultipleEnumeration
        }

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            var query = from conditionType in typeof(ArgumentFactory).Assembly.GetTypes()
                        where conditionType.Name == "StringRes"
                        select conditionType;

            srType = query.SingleOrDefault();

            Assert.IsNotNull(srType, "The type StringRes could not be found in the Trustsoft.Conditions assembly.");
        }

        [TestMethod]
        [TestCategory("Resources")]
        [Description("Validates whether the defined string consts in StringRes class have a value that equals it's name.")]
        public void Validate_StringResources_Method1()
        {
            Assert.IsNotNull(srType, "The type StringRes could not be found in the Trustsoft.Conditions assembly.");

            foreach (var field in GetStringFields())
            {
                string resourceKey = (string)field.GetValue(null);

                // The value should be equal to it's name.
                string message = string.Format(CultureInfo.InvariantCulture,
                                               "Name of StringRes.{0} should match it's value",
                                               field.Name);

                Assert.AreEqual(field.Name, resourceKey, message);
            }
        }

        [TestMethod]
        [TestCategory("Resources")]
        [Description("Validates whether the defined string consts in StringRes class reference an existing string resource.")]
        public void Validate_StringResources_Method2()
        {
            foreach (var field in GetStringFields())
            {
                string resourceKey = (string)field.GetValue(null);
                string resourceValue = StringRes.GetString(resourceKey);

                string assertExplanation = string.Format(CultureInfo.InvariantCulture,
                                                         "The resource with key '{0}' could not be found.",
                                                         resourceKey);

                Assert.IsTrue(!string.IsNullOrEmpty(resourceValue), assertExplanation);
            }
        }
    }
}