//------------------------Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Boolean.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.------------------------

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
    public class BooleanUnitTest
    {
        #region " IsTrue "

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue1()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue2()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [Description("Calling IsTrue on ()=>true should pass.")]
        public void IsTrue_ShouldPass_OnTrueValue3()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(() => arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue1()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue2()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on ()=>false should fail.")]
        public void IsTrue_ShouldFail_OnFalseValue3()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(() => arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnNullableTrueValue1()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [Description("Calling IsTrue on true should pass.")]
        public void IsTrue_ShouldPass_OnNullableTrueValue2()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [Description("Calling IsTrue on ()=>true should pass.")]
        public void IsTrue_ShouldPass_OnNullableTrueValue3()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(() => arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnNullableFalseValue1()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(arg).IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on false should fail.")]
        public void IsTrue_ShouldFail_OnNullableFalseValue2()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsTrue();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsTrue")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsTrue on ()=>false should fail.")]
        public void IsTrue_ShouldFail_OnNullableFalseValue3()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(() => arg).IsTrue();
        }

        #endregion

        #region " IsFalse "

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue1()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue2()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [Description("Calling IsFalse on ()=>false should pass.")]
        public void IsFalse_ShouldPass_OnFalseValue3()
        {
            // Arrange
            bool arg = false;

            // Act/Assert
            Requires.That(() => arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue1()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue2()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on ()=>true should fail.")]
        public void IsFalse_ShouldFail_OnTrueValue3()
        {
            // Arrange
            bool arg = true;

            // Act/Assert
            Requires.That(() => arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnNullableFalseValue1()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [Description("Calling IsFalse on false should pass.")]
        public void IsFalse_ShouldPass_OnNullableFalseValue2()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [Description("Calling IsFalse on ()=>false should pass.")]
        public void IsFalse_ShouldPass_OnNullableFalseValue3()
        {
            // Arrange
            bool? arg = false;

            // Act/Assert
            Requires.That(() => arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnNullableTrueValue1()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(arg).IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on true should fail.")]
        public void IsFalse_ShouldFail_OnNullableTrueValue2()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(arg, "arg").IsFalse();
        }

        [TestMethod]
        [TestCategory("Boolean? - IsFalse")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsFalse on ()=>true should fail.")]
        public void IsFalse_ShouldFail_OnNullableTrueValue3()
        {
            // Arrange
            bool? arg = true;

            // Act/Assert
            Requires.That(() => arg).IsFalse();
        }

        #endregion
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}