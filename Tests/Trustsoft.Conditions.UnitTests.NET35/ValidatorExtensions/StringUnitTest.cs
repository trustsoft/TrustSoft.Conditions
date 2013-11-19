//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="String.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>19.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ExpressionIsAlwaysNull

    [TestClass]
    public class StringUnitTest
    {
        #region " IsEmpty "

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [Description("Calling IsEmpty on String.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg).IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [Description("Calling IsEmpty on String.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [Description("Calling IsEmpty on ()=>String.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(() => arg).IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-null should fail.")]
        public void IsEmpty_ShouldFail_OnNonNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(arg).IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-null should fail.")]
        public void IsEmpty_ShouldFail_OnNonNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(arg, "arg").IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on ()=>non-null should fail.")]
        public void IsEmpty_ShouldFail_OnNonNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(() => arg).IsEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNotEmpty "

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-null should pass.")]
        public void IsNotEmpty_ShouldPass_OnStringValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg).IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-null should pass.")]
        public void IsNotEmpty_ShouldPass_OnStringValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg, "arg").IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [Description("Calling IsNotEmpty on ()=>non-null should pass.")]
        public void IsNotEmpty_ShouldPass_OnStringValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(() => arg).IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on null should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = "";

            // Act/Assert
            Requires.That(arg).IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on null should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on ()=>null should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(() => arg).IsNotEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNullOrEmpty "

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [Description("Calling IsNullOrEmpty on null should pass.")]
        public void IsNullOrEmpty_ShouldPass_OnNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(arg).IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [Description("Calling IsNullOrEmpty on null should pass.")]
        public void IsNullOrEmpty_ShouldPass_OnNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [Description("Calling IsNullOrEmpty on ()=>null should pass.")]
        public void IsNullOrEmpty_ShouldPass_OnNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrEmpty on non-null should fail.")]
        public void IsNullOrEmpty_ShouldFail_OnNonNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg).IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrEmpty on non-null should fail.")]
        public void IsNullOrEmpty_ShouldFail_OnNonNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg, "arg").IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrEmpty on ()=>non-null should fail.")]
        public void IsNullOrEmpty_ShouldFail_OnNonNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(() => arg).IsNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNotNullOrEmpty "

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [Description("Calling IsNotNullOrEmpty on non-null should pass.")]
        public void IsNotNullOrEmpty_ShouldPass_OnStringValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg).IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [Description("Calling IsNotNullOrEmpty on non-null should pass.")]
        public void IsNotNullOrEmpty_ShouldPass_OnStringValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg, "arg").IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [Description("Calling IsNotNullOrEmpty on ()=>non-null should pass.")]
        public void IsNotNullOrEmpty_ShouldPass_OnStringValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(() => arg).IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNullOrEmpty on null should fail.")]
        public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(arg).IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNullOrEmpty on null should fail.")]
        public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrEmpty")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNullOrEmpty on ()=>null should fail.")]
        public void IsNotNullOrEmpty_ShouldFail_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNotNullOrEmpty();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNullOrWhiteSpace "

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on String.Empty should pass.")]
        public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = "";

            // Act/Assert
            Requires.That(arg).IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on String.Empty should pass.")]
        public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on ()=>String.Empty should pass.")]
        public void IsNullOrWhiteSpace_ShouldPass_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(() => arg).IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrWhiteSpace on non-null should fail.")]
        public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(arg).IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrWhiteSpace on non-null should fail.")]
        public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(arg, "arg").IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNullOrWhiteSpace on ()=>non-null should fail.")]
        public void IsNullOrWhiteSpace_ShouldFail_OnNonNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 12);

            // Act/Assert
            Requires.That(() => arg).IsNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNotNullOrWhiteSpace "

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [Description("Calling IsNotNullOrWhiteSpace on non-null should pass.")]
        public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg).IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [Description("Calling IsNotNullOrWhiteSpace on non-null should pass.")]
        public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(arg, "arg").IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [Description("Calling IsNotNullOrWhiteSpace on ()=>non-null should pass.")]
        public void IsNotNullOrWhiteSpace_ShouldPass_OnStringValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = new string('-', 21);

            // Act/Assert
            Requires.That(() => arg).IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotNullOrWhiteSpace on null should fail.")]
        public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg).IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotNullOrWhiteSpace on null should fail.")]
        public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("String - IsNotNullOrWhiteSpace")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotNullOrWhiteSpace on ()=>null should fail.")]
        public void IsNotNullOrWhiteSpace_ShouldFail_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            string arg = string.Empty;

            // Act/Assert
            Requires.That(() => arg).IsNotNullOrWhiteSpace();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion
    }

    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}