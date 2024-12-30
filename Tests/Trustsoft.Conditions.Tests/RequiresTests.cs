﻿//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="RequiresTests.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>21.02.2016</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Tests;

using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class RequiresTests
{
    #region " Requires.That "

    [TestMethod]
    [TestCategory("Requires.That")]
    [Description("Requires.That should behaves correctly.")]
    public void RequiresThat_ShouldBehaves_Correctly1()
    {
        // Arrange
        int value = 23;

        // Act/Assert
        Assert.IsNotNull(Requires.That(() => value));
        Assert.IsNotNull(Requires.That(() => value).IsLessThan(56));
    }

    [TestMethod]
    [TestCategory("Requires.That")]
    [Description("Requires.That should behaves correctly.")]
    public void RequiresThat_ShouldBehaves_Correctly2()
    {
        // Arrange
        int value = 23;

        // Act/Assert
        var validator = Requires.That(() => value).IsLessThan(56);
        Assert.IsTrue(validator.IsValid());
        Assert.AreEqual(0, validator.GetErrors().Count());
    }

    [TestMethod]
    [TestCategory("Requires.That")]
    [Description("Requires.That should behaves correctly.")]
    public void RequiresThat_ShouldBehaves_Correctly3()
    {
        // Arrange
        int value = 123;

        // Act/Assert
        var validator = Requires.That(value, "value").IsLessThan(546);
        Assert.IsTrue(validator.IsValid());
        Assert.AreEqual(0, validator.GetErrors().Count());
    }

    #endregion
}