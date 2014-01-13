//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidateUnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>22.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class ValidateUnitTest
    {
        [TestMethod]
        [TestCategory("Validate.That")]
        [Description("Validate.That should behaves correctly.")]
        public void ValidateThatShouldBehavesCorrectly1()
        {
            // Arrange
            int value = 23;

            // Act/Assert
            var validator = Validate.That(() => value).IsLessThan(56);
            Assert.IsTrue(validator.IsValid());
            Assert.AreEqual(0, validator.GetErrors().Count());
        }

        [TestMethod]
        [TestCategory("Validate.That")]
        [Description("Validate.That should behaves correctly.")]
        public void ValidateThatShouldBehavesCorrectly2()
        {
            // Arrange
            int value = 123;

            // Act/Assert
            var validator = Validate.That(value, "value").IsLessThan(56);
            Assert.IsFalse(validator.IsValid());
            Assert.AreEqual(1, validator.GetErrors().Count());
        }
    }
}