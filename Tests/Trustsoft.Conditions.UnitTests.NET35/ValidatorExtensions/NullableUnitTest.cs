//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Nullable.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ExpressionIsAlwaysNull
    // ReSharper disable ConditionIsAlwaysTrueOrFalse

    [TestClass]
    public class NullableUnitTest
    {
        #region " IsNull "

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue1()
        {
            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue2()
        {
            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [Description("Calling IsNull on ()=>null should pass.")]
        public void IsNull_ShouldPass_OnNullValue3()
        {
            // Arrange
            double? arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue1()
        {
            // Arrange
            int? arg = 678;

            // Act/Assert
            Requires.That(arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue2()
        {
            // Arrange
            int? arg = 234;

            // Act/Assert
            Requires.That(arg, "arg").IsNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on ()=>non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue3()
        {
            // Arrange
            int? arg = 804;

            // Act/Assert
            Requires.That(() => arg).IsNull();
        }

        #endregion

        #region " IsNotNull "

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue1()
        {
            // Arrange
            int? arg = 87;

            // Act/Assert
            Requires.That(arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue2()
        {
            // Arrange
            int? arg = 87;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [Description("Calling IsNotNull on ()=>non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue3()
        {
            // Arrange
            double? arg = 38;

            // Act/Assert
            Requires.That(() => arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue1()
        {
            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue2()
        {
            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();
        }

        [TestMethod]
        [TestCategory("Nullable - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on ()=>null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue3()
        {
            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNotNull();
        }

        #endregion
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}