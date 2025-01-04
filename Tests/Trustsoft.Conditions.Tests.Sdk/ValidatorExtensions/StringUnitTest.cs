// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------
//  <copyright file="StringUnitTest.cs" author="M.Sukhanov">
//      Copyright © 2024 M.Sukhanov. All rights reserved.
//  </copyright>
//  <date>19.11.2013</date>
// -------------------------Copyright © 2024 M.Sukhanov. All rights reserved.-------------------------

#pragma warning disable CS8620 // Argument cannot be used for parameter due to differences in the nullability of reference types.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions;

[TestClass]
public class StringUnitTest
{
    #region " Helper Regex Patterns "

    private const string IPAddressRegexPattern =
            @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

    #endregion

    #region " IsEmpty "

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [Description("Calling IsEmpty on String.Empty should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [Description("Calling IsEmpty on String.Empty should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [Description("Calling IsEmpty on ()=>String.Empty should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-null should fail.")]
    public void IsEmpty_ShouldFail_OnNonNullValue1()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(arg).IsEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-null should fail.")]
    public void IsEmpty_ShouldFail_OnNonNullValue2()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(arg, "arg").IsEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on ()=>non-null should fail.")]
    public void IsEmpty_ShouldFail_OnNonNullValue3()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(() => arg).IsEmpty();
    }

    #endregion

    #region " IsNotEmpty "

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-null should pass.")]
    public void IsNotEmpty_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-null should pass.")]
    public void IsNotEmpty_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [Description("Calling IsNotEmpty on ()=>non-null should pass.")]
    public void IsNotEmpty_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on null should fail.")]
    public void IsNotEmpty_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = "";

        // Act/Assert
        Requires.That(arg).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on null should fail.")]
    public void IsNotEmpty_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on ()=>null should fail.")]
    public void IsNotEmpty_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsNotEmpty();
    }

    #endregion

    #region " IsNullOrEmpty "

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [Description("Calling IsNullOrEmpty on null should pass.")]
    public void IsNullOrEmpty_ShouldPass_OnNullValue1()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(arg).IsNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [Description("Calling IsNullOrEmpty on null should pass.")]
    public void IsNullOrEmpty_ShouldPass_OnNullValue2()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(arg, "arg").IsNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [Description("Calling IsNullOrEmpty on ()=>null should pass.")]
    public void IsNullOrEmpty_ShouldPass_OnNullValue3()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(() => arg).IsNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrEmpty on non-null should fail.")]
    public void IsNullOrEmpty_ShouldFail_OnNonNullValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).IsNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrEmpty on non-null should fail.")]
    public void IsNullOrEmpty_ShouldFail_OnNonNullValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").IsNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrEmpty on ()=>non-null should fail.")]
    public void IsNullOrEmpty_ShouldFail_OnNonNullValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).IsNullOrEmpty();
    }

    #endregion

    #region " IsNotNullOrEmpty "

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [Description("Calling IsNotNullOrEmpty on non-null should pass.")]
    public void IsNotNullOrEmpty_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).IsNotNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [Description("Calling IsNotNullOrEmpty on non-null should pass.")]
    public void IsNotNullOrEmpty_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").IsNotNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [Description("Calling IsNotNullOrEmpty on ()=>non-null should pass.")]
    public void IsNotNullOrEmpty_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).IsNotNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [ExpectedException(typeof(ArgumentNullException))]
    [Description("Calling IsNotNullOrEmpty on null should fail.")]
    public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(arg).IsNotNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [ExpectedException(typeof(ArgumentNullException))]
    [Description("Calling IsNotNullOrEmpty on null should fail.")]
    public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(arg, "arg").IsNotNullOrEmpty();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrEmpty")]
    [ExpectedException(typeof(ArgumentNullException))]
    [Description("Calling IsNotNullOrEmpty on ()=>null should fail.")]
    public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(() => arg).IsNotNullOrEmpty();
    }

    #endregion

    #region " IsNullOrWhiteSpace "

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on String.Empty should pass.")]
    public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = "";

        // Act/Assert
        Requires.That(arg).IsNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on String.Empty should pass.")]
    public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [Description("Calling IsNullOrWhiteSpace on ()=>String.Empty should pass.")]
    public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrWhiteSpace on non-null should fail.")]
    public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue1()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(arg).IsNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrWhiteSpace on non-null should fail.")]
    public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue2()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(arg, "arg").IsNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNullOrWhiteSpace on ()=>non-null should fail.")]
    public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue3()
    {
        // Arrange
        string arg = new string('-', 12);

        // Act/Assert
        Requires.That(() => arg).IsNullOrWhiteSpace();
    }

    #endregion

    #region " IsNotNullOrWhiteSpace "

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [Description("Calling IsNotNullOrWhiteSpace on non-null should pass.")]
    public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).IsNotNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [Description("Calling IsNotNullOrWhiteSpace on non-null should pass.")]
    public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").IsNotNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [Description("Calling IsNotNullOrWhiteSpace on ()=>non-null should pass.")]
    public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).IsNotNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotNullOrWhiteSpace on null should fail.")]
    public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsNotNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotNullOrWhiteSpace on null should fail.")]
    public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsNotNullOrWhiteSpace();
    }

    [TestMethod]
    [TestCategory("String - IsNotNullOrWhiteSpace")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotNullOrWhiteSpace on ()=>null should fail.")]
    public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsNotNullOrWhiteSpace();
    }

    #endregion

    #region " StartsWith "

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [Description("Calling StartsWith on non-null should pass.")]
    public void StartsWith_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).StartsWith("--");
    }

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [Description("Calling StartsWith on non-null should pass.")]
    public void StartsWith_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").StartsWith("--");
    }

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [Description("Calling StartsWith on ()=>non-null should pass.")]
    public void StartsWith_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).StartsWith("-");
    }

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling StartsWith on null should fail.")]
    public void StartsWith_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).StartsWith("-");
    }

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling StartsWith on null should fail.")]
    public void StartsWith_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").StartsWith("-");
    }

    [TestMethod]
    [TestCategory("String - StartsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling StartsWith on ()=>null should fail.")]
    public void StartsWith_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).StartsWith("-");
    }

    #endregion

    #region " DoesNotStartWith "

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on non-null should pass.")]
    public void DoesNotStartsWith_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).DoesNotStartWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on non-null should pass.")]
    public void DoesNotStartsWith_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").DoesNotStartWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on ()=>non-null should pass.")]
    public void DoesNotStartsWith_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).DoesNotStartWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on null should fail.")]
    public void DoesNotStartsWith_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).DoesNotStartWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on null should fail.")]
    public void DoesNotStartsWith_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").DoesNotStartWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotStartWith")]
    [Description("Calling DoesNotStartWith on ()=>null should fail.")]
    public void DoesNotStartsWith_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).DoesNotStartWith("+");
    }

    #endregion

    #region " EndsWith "

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [Description("Calling EndsWith on non-null should pass.")]
    public void EndsWith_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).EndsWith("--");
    }

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [Description("Calling EndsWith on non-null should pass.")]
    public void EndsWith_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").EndsWith("--");
    }

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [Description("Calling EndsWith on ()=>non-null should pass.")]
    public void EndsWith_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).EndsWith("-");
    }

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling EndsWith on null should fail.")]
    public void EndsWith_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).EndsWith("-");
    }

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling EndsWith on null should fail.")]
    public void EndsWith_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").EndsWith("-");
    }

    [TestMethod]
    [TestCategory("String - EndsWith")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling EndsWith on ()=>null should fail.")]
    public void EndsWith_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).EndsWith("-");
    }

    #endregion

    #region " DoesNotEndWith "

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on non-null should pass.")]
    public void DoesNotEndsWith_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).DoesNotEndWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on non-null should pass.")]
    public void DoesNotEndsWith_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").DoesNotEndWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on ()=>non-null should pass.")]
    public void DoesNotEndsWith_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).DoesNotEndWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on null should fail.")]
    public void DoesNotEndsWith_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).DoesNotEndWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on null should fail.")]
    public void DoesNotEndsWith_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").DoesNotEndWith("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotEndWith")]
    [Description("Calling DoesNotEndWith on ()=>null should fail.")]
    public void DoesNotEndsWith_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).DoesNotEndWith("+");
    }

    #endregion

    #region " Contains "

    [TestMethod]
    [TestCategory("String - Contains")]
    [Description("Calling Contains on non-null should pass.")]
    public void Contains_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).Contains("--");
    }

    [TestMethod]
    [TestCategory("String - Contains")]
    [Description("Calling Contains on non-null should pass.")]
    public void Contains_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").Contains("--");
    }

    [TestMethod]
    [TestCategory("String - Contains")]
    [Description("Calling Contains on ()=>non-null should pass.")]
    public void Contains_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).Contains("-");
    }

    [TestMethod]
    [TestCategory("String - Contains")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling Contains on null should fail.")]
    public void Contains_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).Contains("-");
    }

    [TestMethod]
    [TestCategory("String - Contains")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling Contains on null should fail.")]
    public void Contains_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").Contains("-");
    }

    [TestMethod]
    [TestCategory("String - Contains")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling Contains on ()=>null should fail.")]
    public void Contains_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).Contains("-");
    }

    #endregion

    #region " DoesNotContain "

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [Description("Calling DoesNotContain on non-null should pass.")]
    public void DoesNotContains_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).DoesNotContain("++");
    }

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [Description("Calling DoesNotContain on non-null should pass.")]
    public void DoesNotContains_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").DoesNotContain("+");
    }

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [Description("Calling DoesNotContain on ()=>non-null should pass.")]
    public void DoesNotContains_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).DoesNotContain("0");
    }

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotContain on null should fail.")]
    public void DoesNotContains_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg).DoesNotContain("-");
    }

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotContain on null should fail.")]
    public void DoesNotContains_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(arg, "arg").DoesNotContain("-");
    }

    [TestMethod]
    [TestCategory("String - DoesNotContain")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotContain on ()=>null should fail.")]
    public void DoesNotContains_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = new string('-', 21);

        // Act/Assert
        Requires.That(() => arg).DoesNotContain("-");
    }

    #endregion

    #region " IsMatch "

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [Description("Calling IsMatch on non-null should pass.")]
    public void IsMatch_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = "192.168.1.1";

        // Act/Assert
        Requires.That(arg).IsMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [Description("Calling IsMatch on non-null should pass.")]
    public void IsMatch_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = "192.168.1.1";

        // Act/Assert
        Requires.That(arg, "arg").IsMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [Description("Calling IsMatch on ()=>non-null should pass.")]
    public void IsMatch_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = "192.168.1.1";

        // Act/Assert
        Requires.That(() => arg).IsMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [ExpectedException(typeof(ArgumentNullException))]
    [Description("Calling IsMatch on null should fail.")]
    public void IsMatch_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = null;

        // Act/Assert
        Requires.That(arg).IsMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsMatch on null should fail.")]
    public void IsMatch_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsMatch")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsMatch on ()=>null should fail.")]
    public void IsMatch_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsMatch(IPAddressRegexPattern);
    }

    #endregion

    #region " IsNotMatch "

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [Description("Calling IsNotMatch on non-null should pass.")]
    public void IsNotMatch_ShouldPass_OnStringValue1()
    {
        // Arrange
        string arg = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        // Act/Assert
        Requires.That(arg).IsNotMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [Description("Calling IsNotMatch on non-null should pass.")]
    public void IsNotMatch_ShouldPass_OnStringValue2()
    {
        // Arrange
        string arg = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        // Act/Assert
        Requires.That(arg, "arg").IsNotMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [Description("Calling IsNotMatch on ()=>non-null should pass.")]
    public void IsNotMatch_ShouldPass_OnStringValue3()
    {
        // Arrange
        string arg = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";

        // Act/Assert
        Requires.That(() => arg).IsNotMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotMatch on null should fail.")]
    public void IsNotMatch_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = @"172.29.148.6";

        // Act/Assert
        Requires.That(arg).IsNotMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotMatch on null should fail.")]
    public void IsNotMatch_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = @"172.29.148.6";

        // Act/Assert
        Requires.That(arg, "arg").IsNotMatch(IPAddressRegexPattern);
    }

    [TestMethod]
    [TestCategory("String - IsNotMatch")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotMatch on ()=>null should fail.")]
    public void IsNotMatch_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = @"172.29.148.6";

        // Act/Assert
        Requires.That(() => arg).IsNotMatch(IPAddressRegexPattern);
    }

    #endregion

    #region " IsShorterThan "

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on '123' should pass.")]
    public void IsShorterThan_ShouldPass_OnShorterValue1()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg).IsShorterThan(4);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on '123' should pass.")]
    public void IsShorterThan_ShouldPass_OnShorterValue2()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg, "arg").IsShorterThan(4);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on ()=>'123' should pass.")]
    public void IsShorterThan_ShouldPass_OnShorterValue3()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(() => arg).IsShorterThan(4);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on String.Empty should pass.")]
    public void IsShorterThan_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsShorterThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on String.Empty should pass.")]
    public void IsShorterThan_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsShorterThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [Description("Calling IsShorterThan on ()=>String.Empty should pass.")]
    public void IsShorterThan_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsShorterThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterThan on non-null should fail.")]
    public void IsShorterThan_ShouldFail_OnLongerValue1()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg).IsShorterThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterThan on non-null should fail.")]
    public void IsShorterThan_ShouldFail_OnLongerValue2()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg, "arg").IsShorterThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterThan on ()=>non-null should fail.")]
    public void IsShorterThan_ShouldFail_OnLongerValue3()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(() => arg).IsShorterThan(5);
    }

    #endregion

    #region " IsShorterOrEqual "

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on '123' should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnShorterValue1()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg).IsShorterOrEqual(4);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on '123' should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnShorterValue2()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg, "arg").IsShorterOrEqual(3);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on ()=>'123' should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnShorterValue3()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(() => arg).IsShorterOrEqual(4);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on String.Empty should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsShorterOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on String.Empty should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsShorterOrEqual(0);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [Description("Calling IsShorterOrEqual on ()=>String.Empty should pass.")]
    public void IsShorterOrEqual_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsShorterOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterOrEqual on non-null should fail.")]
    public void IsShorterOrEqual_ShouldFail_OnLongerValue1()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg).IsShorterOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterOrEqual on non-null should fail.")]
    public void IsShorterOrEqual_ShouldFail_OnLongerValue2()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg, "arg").IsShorterOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsShorterOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsShorterOrEqual on ()=>non-null should fail.")]
    public void IsShorterOrEqual_ShouldFail_OnLongerValue3()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(() => arg).IsShorterOrEqual(5);
    }

    #endregion

    #region " IsLongerThan "

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [Description("Calling IsLongerThan on '1234567' should pass.")]
    public void IsLongerThan_ShouldPass_OnLongerValue1()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(arg).IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [Description("Calling IsLongerThan on '1234567' should pass.")]
    public void IsLongerThan_ShouldPass_OnLongerValue2()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(arg, "arg").IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [Description("Calling IsLongerThan on ()=>'1234567' should pass.")]
    public void IsLongerThan_ShouldPass_OnLongerValue3()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(() => arg).IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on String.Empty should pass.")]
    public void IsLongerThan_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on String.Empty should pass.")]
    public void IsLongerThan_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on ()=>String.Empty should pass.")]
    public void IsLongerThan_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on non-null should fail.")]
    public void IsLongerThan_ShouldFail_OnShorterValue1()
    {
        // Arrange
        string arg = new string('-', 2);

        // Act/Assert
        Requires.That(arg).IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on non-null should fail.")]
    public void IsLongerThan_ShouldFail_OnShorterValue2()
    {
        // Arrange
        string arg = new string('-', 3);

        // Act/Assert
        Requires.That(arg, "arg").IsLongerThan(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerThan")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerThan on ()=>non-null should fail.")]
    public void IsLongerThan_ShouldFail_OnShorterValue3()
    {
        // Arrange
        string arg = new string('-', 4);

        // Act/Assert
        Requires.That(() => arg).IsLongerThan(5);
    }

    #endregion

    #region " IsLongerOrEqual "

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [Description("Calling IsLongerOrEqual on '1234567' should pass.")]
    public void IsLongerOrEqual_ShouldPass_OnLongerValue1()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(arg).IsLongerOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [Description("Calling IsLongerOrEqual on '1234567' should pass.")]
    public void IsLongerOrEqual_ShouldPass_OnLongerValue2()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(arg, "arg").IsLongerOrEqual(7);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [Description("Calling IsLongerOrEqual on ()=>'1234567' should pass.")]
    public void IsLongerOrEqual_ShouldPass_OnLongerValue3()
    {
        // Arrange
        string arg = "1234567";

        // Act/Assert
        Requires.That(() => arg).IsLongerOrEqual(6);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on String.Empty should pass.")]
    public void IsLongerOrEqual_ShouldFail_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).IsLongerOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on String.Empty should pass.")]
    public void IsLongerOrEqual_ShouldFail_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").IsLongerOrEqual(3);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on ()=>String.Empty should pass.")]
    public void IsLongerOrEqual_ShouldFail_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).IsLongerOrEqual(7);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on non-null should fail.")]
    public void IsLongerOrEqual_ShouldFail_OnShorterValue1()
    {
        // Arrange
        string arg = new string('-', 2);

        // Act/Assert
        Requires.That(arg).IsLongerOrEqual(5);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on non-null should fail.")]
    public void IsLongerOrEqual_ShouldFail_OnShorterValue2()
    {
        // Arrange
        string arg = new string('-', 3);

        // Act/Assert
        Requires.That(arg, "arg").IsLongerOrEqual(4);
    }

    [TestMethod]
    [TestCategory("String - IsLongerOrEqual")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsLongerOrEqual on ()=>non-null should fail.")]
    public void IsLongerOrEqual_ShouldFail_OnShorterValue3()
    {
        // Arrange
        string arg = new string('-', 4);

        // Act/Assert
        Requires.That(() => arg).IsLongerOrEqual(5);
    }

    #endregion

    #region " HasLength "

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on '123' should pass.")]
    public void HasLength_ShouldPass_OnCorrectLengthValue1()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg).HasLength(3);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on '123' should pass.")]
    public void HasLength_ShouldPass_OnCorrectLengthValue2()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg, "arg").HasLength(3);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on ()=>'123' should pass.")]
    public void HasLength_ShouldPass_OnCorrectLengthValue3()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(() => arg).HasLength(3);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on String.Empty should pass.")]
    public void HasLength_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).HasLength(0);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on String.Empty should pass.")]
    public void HasLength_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").HasLength(0);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [Description("Calling HasLength on ()=>String.Empty should pass.")]
    public void HasLength_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).HasLength(0);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling HasLength on non-null should fail.")]
    public void HasLength_ShouldPass_OnLongerValue1()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg).HasLength(9);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling HasLength on non-null should fail.")]
    public void HasLength_ShouldPass_OnLongerValue2()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg, "arg").HasLength(9);
    }

    [TestMethod]
    [TestCategory("String - HasLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling HasLength on ()=>non-null should fail.")]
    public void HasLength_ShouldPass_OnLongerValue3()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(() => arg).HasLength(9);
    }

    #endregion

    #region " DoesNotHaveLength "

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on '123' should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnCorrectLengthValue1()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg).DoesNotHaveLength(7);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on '123' should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnCorrectLengthValue2()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(arg, "arg").DoesNotHaveLength(8);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on ()=>'123' should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnCorrectLengthValue3()
    {
        // Arrange
        string arg = "123";

        // Act/Assert
        Requires.That(() => arg).DoesNotHaveLength(9);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on String.Empty should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnEmptyValue1()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg).DoesNotHaveLength(1);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on String.Empty should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnEmptyValue2()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(arg, "arg").DoesNotHaveLength(2);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [Description("Calling DoesNotHaveLength on ()=>String.Empty should pass.")]
    public void DoesNotHaveLength_ShouldPass_OnEmptyValue3()
    {
        // Arrange
        string arg = string.Empty;

        // Act/Assert
        Requires.That(() => arg).DoesNotHaveLength(3);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotHaveLength on non-null should fail.")]
    public void DoesNotHaveLength_ShouldFail_OnLongerValue1()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg).DoesNotHaveLength(6);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotHaveLength on non-null should fail.")]
    public void DoesNotHaveLength_ShouldFail_OnLongerValue2()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(arg, "arg").DoesNotHaveLength(6);
    }

    [TestMethod]
    [TestCategory("String - DoesNotHaveLength")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling DoesNotHaveLength on ()=>non-null should fail.")]
    public void DoesNotHaveLength_ShouldFail_OnLongerValue3()
    {
        // Arrange
        string arg = new string('-', 6);

        // Act/Assert
        Requires.That(() => arg).DoesNotHaveLength(6);
    }

    #endregion
}