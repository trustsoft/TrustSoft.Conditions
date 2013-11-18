//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Class.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Trustsoft.Conditions.UnitTests.Helpers;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ExpressionIsAlwaysNull

    [TestClass]
    public class ClassUnitTest
    {
        #region " IsOfType "

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsOfType on Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(arg).IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsOfType on Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(arg, "arg").IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsOfType on ()=>Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(() => arg).IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on ()=>new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion

        #region " IsNotOfType "

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsNotOfType on new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsNotOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsNotOfType on new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsNotOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [Description("Calling IsNotOfType on ()=>new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsNotOfType(typeof(Model));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue1()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsNotOfType(typeof(ModelBase));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue2()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsNotOfType(typeof(ModelBase));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        [TestMethod]
        [TestCategory("Type")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on ()=>Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue3()
        {
            // ReSharper disable ConditionIsAlwaysTrueOrFalse

            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsNotOfType(typeof(ModelBase));

            // ReSharper restore ConditionIsAlwaysTrueOrFalse
        }

        #endregion
    }

    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}