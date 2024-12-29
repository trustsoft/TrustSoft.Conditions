//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ValidateUnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>22.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Tests
{
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ValidateUnitTest
    {
        #region " Validate.That "

        [TestMethod]
        [TestCategory("Validate.That")]
        [Description("Validate.That should behaves correctly.")]
        public void ValidateThat_ShouldBehaves_Correctly1()
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
        public void ValidateThat_ShouldBehaves_Correctly2()
        {
            // Arrange
            int value = 123;

            // Act/Assert
            var validator = Validate.That(value, "value").IsLessThan(56);
            Assert.IsFalse(validator.IsValid());
            Assert.AreEqual(1, validator.GetErrors().Count());
        }

        #endregion
    }
}