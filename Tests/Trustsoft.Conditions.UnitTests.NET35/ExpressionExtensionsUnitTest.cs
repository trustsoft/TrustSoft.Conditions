//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ExpressionExtensionsUnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>21.02.2016</date>
//------------------------Copyright © 2012-2016 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Trustsoft.Conditions.UnitTests.Helpers;

    #endregion

    [TestClass]
    public class ExpressionExtensionsUnitTest
    {
        [TestMethod]
        [TestCategory("ExpressionExtensions")]
        [ExpectedException(typeof(InvalidCastException))]
        [Description("ExpressionExtensions.GetValue should behaves correctly.")]
        public void GetValue_ShouldBehaves_Correctly1()
        {
            // Arrange
            Expression<Func<int>> expression = () => 5;

            // Act/Assert
            Assert.AreEqual(5, expression.GetValue());
        }

        [TestMethod]
        [TestCategory("ExpressionExtensions")]
        [Description("ExpressionExtensions.GetValue should behaves correctly.")]
        public void GetValue_ShouldBehaves_Correctly2()
        {
            // Arrange
            var model = new Model(45);
            Expression<Func<int>> expression = () => model.Number;

            // Act/Assert
            Assert.AreEqual(model.Number, expression.GetValue());
        }

        [TestMethod]
        [TestCategory("ExpressionExtensions")]
        [Description("ExpressionExtensions.GetValue should behaves correctly.")]
        public void GetValue_ShouldBehaves_Correctly3()
        {
            // Arrange
            var model = new Model(45);
            Expression<Func<int>> expression = () => model.Number;

            // Act/Assert
            Assert.AreEqual("Number", expression.GetName());
            Assert.AreEqual(model.Number, expression.GetValue());
        }
    }
}