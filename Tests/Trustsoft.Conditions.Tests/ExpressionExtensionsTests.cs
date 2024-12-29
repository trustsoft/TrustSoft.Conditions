﻿//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ExpressionExtensionsTests.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>21.02.2016</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests
{
    using System;
    using System.Linq.Expressions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Trustsoft.Conditions.UnitTests.Helpers;

    // ReSharper disable InconsistentNaming

    [TestClass]
    public class ExpressionExtensionsTests
    {
        #region " GetValue "

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

        #endregion

        #region " GetName "

        [TestMethod]
        [TestCategory("ExpressionExtensions")]
        [Description("ExpressionExtensions.GetName should behaves correctly.")]
        public void GetName_ShouldBehaves_Correctly1()
        {
            // Arrange
            var model = new Model(45);
            Expression<Func<int>> expression = () => model.Number;

            // Act/Assert
            Assert.AreEqual("Number", expression.GetName());
        }

        [TestMethod]
        [TestCategory("ExpressionExtensions")]
        [ExpectedException(typeof(InvalidOperationException))]
        [Description("ExpressionExtensions.GetName should behaves correctly.")]
        public void GetName_ShouldBehaves_Correctly2()
        {
            // Arrange
            Expression<Func<int>> expression = () => 5;

            // Act/Assert
            Assert.AreEqual("5", expression.GetName());
        }

        #endregion
    }

    // ReSharper restore InconsistentNaming
}