//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="UnitTest1.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable InconsistentNaming

    [TestClass]
    public class StringHelpersUnitTest
    {
        [TestMethod]
        [TestCategory("StringHelpers - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on null value should return true.")]
        public void IsNullOrWhiteSpace_ShouldReturnTrue_OnNullValue()
        {
            // Arrange
            string arg = null;

            // Act/Assert
            Assert.IsTrue(arg.IsNullOrWhiteSpace());
        }

        [TestMethod]
        [TestCategory("StringHelpers - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on space value should return true.")]
        public void IsNullOrWhiteSpace_ShouldReturnTrue_OnSpaceValue()
        {
            // Arrange
            string arg = " ";

            // Act/Assert
            Assert.IsTrue(arg.IsNullOrWhiteSpace());
        }

        [TestMethod]
        [TestCategory("StringHelpers - IsNullOrWhiteSpace")]
        [Description("Calling IsNullOrWhiteSpace on space value should return true.")]
        public void IsNullOrWhiteSpace_ShouldReturnFalse_OnNonEmptyValue()
        {
            // Arrange
            string arg = "678";

            // Act/Assert
            Assert.IsFalse(arg.IsNullOrWhiteSpace());
        }
    }

    // ReSharper restore InconsistentNaming
}