namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class ValidatorExtensionsUnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Method1()
        {
            int value = 78;

            Requires.That(value, "value").IsLessThan(34);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Method2()
        {
            int value = 123;

            Requires.That(value, "value").IsLessThan(56, "{name}({value}) must be less than {param1}");
        }
    }
}