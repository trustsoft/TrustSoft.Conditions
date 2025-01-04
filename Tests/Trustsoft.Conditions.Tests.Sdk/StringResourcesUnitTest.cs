// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="StringResourcesUnitTest.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>10.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace Trustsoft.Conditions.UnitTests;

using System.Reflection;

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

        srType = query.Single();

        Assert.IsNotNull(srType, "The type StringRes could not be found in the Trustsoft.Conditions assembly.");
    }

    [TestMethod]
    [TestCategory("Resources")]
    [Description("Validates whether the defined string constants in StringRes class have a value that equals it's name.")]
    public void Validate_StringResources_Method1()
    {
        foreach (var field in GetStringFields())
        {
            string resourceKey = (string)field.GetValue(null);

            // The value should be equal to its name.
            string message = $"Name of StringRes.{field.Name} should match it's value";

            Assert.AreEqual(field.Name, resourceKey, message);
        }
    }

    [TestMethod]
    [TestCategory("Resources")]
    [Description("Validates whether the defined string constants in StringRes class reference an existing string resource.")]
    public void Validate_StringResources_Method2()
    {
        foreach (var field in GetStringFields())
        {
            string resourceKey = (string)field.GetValue(null);
            string resourceValue = StringRes.GetResourceByKey(resourceKey);

            string assertExplanation = $"The resource with key '{resourceKey}' could not be found.";

            Assert.IsTrue(!string.IsNullOrEmpty(resourceValue), assertExplanation);
        }
    }
}