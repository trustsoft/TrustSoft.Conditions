//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Boolean.UnitTest.cs" company="Trustsoft Ltd.">
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
    public class BooleanUnitTest
    {
        #region " IsTrue "

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg).IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsTrue on ()=>true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(() => arg).IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg).IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on ()=>false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(() => arg).IsTrue();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsFalse "

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg).IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [Description("Calling IsFalse on ()=>false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(() => arg).IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg).IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Boolean")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on ()=>true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(() => arg).IsFalse();

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion
    }

    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}