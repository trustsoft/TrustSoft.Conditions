//------------------------Copyright © 2012-2015 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="String.UnitTest.cs" company="Trustsoft Ltd.">
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
    public class GuidUnitTest
    {
        #region " IsEmpty "

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [Description("Calling IsEmpty on Guid.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue1()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(arg).IsEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [Description("Calling IsEmpty on Guid.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue2()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [Description("Calling IsEmpty on ()=>Guid.Empty should pass.")]
        public void IsEmpty_ShouldPass_OnEmptyValue3()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(() => arg).IsEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on new Guid() should fail.")]
        public void IsEmpty_ShouldFail_OnGuidValue1()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(arg).IsEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on new Guid() should fail.")]
        public void IsEmpty_ShouldFail_OnGuidValue2()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(arg, "arg").IsEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on ()=>new Guid() should fail.")]
        public void IsEmpty_ShouldFail_OnGuidValue3()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(() => arg).IsEmpty();
        }

        #endregion

        #region " IsNotEmpty "

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [Description("Calling IsNotEmpty on new Guid() should pass.")]
        public void IsNotEmpty_ShouldPass_OnGuidValue1()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(arg).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [Description("Calling IsNotEmpty on new Guid() should pass.")]
        public void IsNotEmpty_ShouldPass_OnGuidValue2()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(arg, "arg").IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [Description("Calling IsNotEmpty on ()=>new Guid() should pass.")]
        public void IsNotEmpty_ShouldPass_OnGuidValue3()
        {
            // Arrange
            Guid arg = new Guid("{D061756F-CC3C-4410-A126-C9D90562F804}");

            // Act/Assert
            Requires.That(() => arg).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on Guid.Empty should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue1()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(arg).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on Guid.Empty should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue2()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(arg, "arg").IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("Guid - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on ()=>Guid.Empty should fail.")]
        public void IsNotEmpty_ShouldFail_OnEmptyValue3()
        {
            // Arrange
            Guid arg = Guid.Empty;

            // Act/Assert
            Requires.That(() => arg).IsNotEmpty();
        }

        #endregion
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}