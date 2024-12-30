// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="CollectionExtensionsTests.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>14.01.2014</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

// ReSharper disable UseCollectionExpression
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace Trustsoft.Conditions.Tests;

using System.Collections;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class CollectionExtensionsTests
{
    #region " IsEmpty "

    [TestMethod]
    [TestCategory("CollectionExtensions - IsEmpty")]
    [Description("Calling IsEmpty on empty sequence should return true.")]
    public void IsEmpty_ShouldReturnTrue_OnEmptySequence()
    {
        // Arrange
        string[] arg1 = { };
        IEnumerable arg2 = arg1;

        // Act/Assert
        Assert.IsTrue(arg1.IsEmpty());
        Assert.IsTrue(arg2.IsEmpty());
    }

    [TestMethod]
    [TestCategory("CollectionExtensions - IsEmpty")]
    [Description("Calling IsEmpty on null sequence should return true.")]
    public void IsEmpty_ShouldReturnTrue_OnNullSequence()
    {
        // Arrange
        string[] arg1 = null;
        IEnumerable arg2 = null;

        // Act/Assert
        Assert.IsTrue(arg1.IsEmpty());
        Assert.IsTrue(arg2.IsEmpty());
    }

    [TestMethod]
    [TestCategory("CollectionExtensions - IsEmpty")]
    [Description("Calling IsEmpty on non-empty sequence should return false.")]
    public void IsEmpty_ShouldReturnFalse_OnNonEmptySequence()
    {
        // Arrange
        int[] arg1 = { 5 };
        IEnumerable arg2 = arg1;

        // Act/Assert
        Assert.IsFalse(arg1.IsEmpty());
        Assert.IsFalse(arg2.IsEmpty());
    }

    #endregion

    #region " HasItems "

    [TestMethod]
    [TestCategory("CollectionExtensions - HasItems")]
    [Description("Calling HasItems on non-empty sequence should return true.")]
    public void HasItems_ShouldReturnTrue_OnNonEmptySequence()
    {
        // Arrange
        int[] arg1 = { 5 };
        IEnumerable arg2 = arg1;

        // Act/Assert
        Assert.IsTrue(arg1.HasItems());
        Assert.IsTrue(arg2.HasItems());
    }

    [TestMethod]
    [TestCategory("CollectionExtensions - HasItems")]
    [Description("Calling HasItems on empty sequence should return false.")]
    public void HasItems_ShouldReturnFalse_OnEmptySequence()
    {
        // Arrange
        int[] arg1 = { };
        IEnumerable arg2 = arg1;

        // Act/Assert
        Assert.IsFalse(arg1.HasItems());
        Assert.IsFalse(arg2.HasItems());
    }

    [TestMethod]
    [TestCategory("CollectionExtensions - HasItems")]
    [Description("Calling HasItems on null sequence should return false.")]
    public void HasItems_ShouldReturnFalse_OnNullSequence()
    {
        // Arrange
        int[] arg1 = null;
        IEnumerable arg2 = null;

        // Act/Assert
        Assert.IsFalse(arg1.HasItems());
        Assert.IsFalse(arg2.HasItems());
    }

    #endregion
}