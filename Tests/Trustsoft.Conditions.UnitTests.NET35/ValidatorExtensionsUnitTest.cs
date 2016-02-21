namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable ConvertToConstant.Local
    // ReSharper disable ConditionIsAlwaysTrueOrFalse

    [TestClass]
    public class ValidatorExtensionsUnitTest
    {
        [TestMethod]
        [TestCategory("ErrorMessage")]
        [Description("Error message should be composed correctly.")]
        public void ErrorMessageShouldBeComposedCorrectly1()
        {
            int value = 123;

            try
            {
                Requires.That(value, "value").IsLessThan(56, "{name}({value}) must be less than {param1}");
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "value(123) must be less than 56");
            }
        }

        [TestMethod]
        [TestCategory("ErrorMessage")]
        [Description("Error message should be composed correctly.")]
        public void ErrorMessageShouldBeComposedCorrectly2()
        {
            // Arrange
            bool arg = false;

            try
            {
                // Act/Assert
                Requires.That(arg, "arg").IsTrue();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "arg should be True");
            }
        }

        [TestMethod]
        [TestCategory("ErrorMessage")]
        [Description("Error message should be composed correctly.")]
        public void ErrorMessageShouldBeComposedCorrectly3()
        {
            // Arrange
            bool arg = false;

            try
            {
                // Act/Assert
                Requires.That(arg).IsTrue();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "value should be True");
            }
        }

        [TestMethod]
        [TestCategory("ErrorMessage")]
        [Description("Error message should be composed correctly.")]
        public void ErrorMessageShouldBeComposedCorrectly4()
        {
            // Arrange
            bool arg = false;

            try
            {
                // Act/Assert
                Requires.That(() => arg).IsTrue();
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "arg should be True");
            }
        }
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ConvertToConstant.Local
}