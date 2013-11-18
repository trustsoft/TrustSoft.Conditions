//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Nullable.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
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
    public class NullableUnitTest
    {
        #region " IsNull "

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg).IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNull on ()=>null should pass.")]
        public void IsNull_ShouldPass_OnNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            double? arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = 678;

            // Act/Assert
            Requires.That(arg).IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = 234;

            // Act/Assert
            Requires.That(arg, "arg").IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on ()=>non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = 804;

            // Act/Assert
            Requires.That(() => arg).IsNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNotNull "

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = 87;

            // Act/Assert
            Requires.That(arg).IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = 87;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [Description("Calling IsNotNull on ()=>non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            double? arg = 38;

            // Act/Assert
            Requires.That(() => arg).IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg).IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Nullable")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on ()=>null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            int? arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNotNull();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion
    }

    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}