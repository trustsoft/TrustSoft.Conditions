// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="StringExtensionsTests.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>20.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace Trustsoft.Conditions.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class StringExtensionsTests
{
    #region " IsNullOrWhiteSpace "

    [TestMethod]
    [TestCategory("StringExtensions - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on null value should return true.")]
    public void IsNullOrWhiteSpace_ShouldReturnTrue_OnNullValue()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Assert.IsTrue(arg.IsNullOrWhiteSpace());
    }

    [TestMethod]
    [TestCategory("StringExtensions - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on space value should return true.")]
    public void IsNullOrWhiteSpace_ShouldReturnTrue_OnSpaceValue()
    {
        // Arrange
        string arg = " ";

        // Act/Assert
        Assert.IsTrue(arg.IsNullOrWhiteSpace());
    }

    [TestMethod]
    [TestCategory("StringExtensions - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on space value should return true.")]
    public void IsNullOrWhiteSpace_ShouldReturnFalse_OnNonEmptyValue()
    {
        // Arrange
        string arg = "678";

        // Act/Assert
        Assert.IsFalse(arg.IsNullOrWhiteSpace());
    }

    #endregion
}