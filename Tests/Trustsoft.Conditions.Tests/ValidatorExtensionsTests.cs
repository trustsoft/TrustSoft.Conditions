//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidatorExtensionsTests.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>22.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Tests;

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ValidatorExtensionsTests
{
    [TestMethod]
    [TestCategory("ErrorMessage")]
    [Description("Error message should be composed correctly.")]
    public void ErrorMessage_ShouldBeComposed_Correctly1()
    {
        int value = 123;

        try
        {
            Requires.That(value, "value").IsLessThan(56, "{name}({value}) must be less than {param1}");
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "value(123) must be less than 56");
        }
    }

    [TestMethod]
    [TestCategory("ErrorMessage")]
    [Description("Error message should be composed correctly.")]
    public void ErrorMessage_ShouldBeComposed_Correctly2()
    {
        // Arrange
        bool arg = false;

        try
        {
            // Act/Assert
            Requires.That(arg, "arg").IsTrue();
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "arg should be True");
        }
    }

    [TestMethod]
    [TestCategory("ErrorMessage")]
    [Description("Error message should be composed correctly.")]
    public void ErrorMessage_ShouldBeComposed_Correctly3()
    {
        // Arrange
        bool arg = false;

        try
        {
            // Act/Assert
            Requires.That(arg).IsTrue();
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "value should be True");
        }
    }

    [TestMethod]
    [TestCategory("ErrorMessage")]
    [Description("Error message should be composed correctly.")]
    public void ErrorMessage_ShouldBeComposed_Correctly4()
    {
        // Arrange
        bool arg = false;

        try
        {
            // Act/Assert
            Requires.That(() => arg).IsTrue();
        }
        catch (Exception e)
        {
            StringAssert.Contains(e.Message, "arg should be True");
        }
    }
}