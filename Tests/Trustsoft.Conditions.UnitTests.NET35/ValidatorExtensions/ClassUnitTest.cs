//------------------------Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Class.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>18.11.2013</date>
//------------------------Copyright © 2012-2017 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Trustsoft.Conditions.UnitTests.Helpers;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ExpressionIsAlwaysNull
    // ReSharper disable ConditionIsAlwaysTrueOrFalse

    [TestClass]
    public class ClassUnitTest
    {
        #region " IsNull "

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue1()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [Description("Calling IsNull on null should pass.")]
        public void IsNull_ShouldPass_OnNullValue2()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [Description("Calling IsNull on ()=>null should pass.")]
        public void IsNull_ShouldPass_OnNullValue3()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue1()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(arg).IsNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue2()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(arg, "arg").IsNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNull")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNull on ()=>non-null should fail.")]
        public void IsNull_ShouldFail_OnNonNullValue3()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(() => arg).IsNull();
        }

        #endregion

        #region " IsNotNull "

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue1()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [Description("Calling IsNotNull on non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue2()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [Description("Calling IsNotNull on ()=>non-null should pass.")]
        public void IsNotNull_ShouldPass_OnNullableValue3()
        {
            // Arrange
            Model arg = new Model();

            // Act/Assert
            Requires.That(() => arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue1()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(arg).IsNotNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue2()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(arg, "arg").IsNotNull();
        }

        [TestMethod]
        [TestCategory("Class - IsNotNull")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling IsNotNull on ()=>null should fail.")]
        public void IsNotNull_ShouldFail_OnEmptyValue3()
        {
            // Arrange
            Model arg = null;

            // Act/Assert
            Requires.That(() => arg).IsNotNull();
        }

        #endregion

        #region " IsOfType "

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [Description("Calling IsOfType on Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue1()
        {
            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(arg).IsOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [Description("Calling IsOfType on Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue2()
        {
            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(arg, "arg").IsOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [Description("Calling IsOfType on ()=>Type.Empty should pass.")]
        public void IsOfType_ShouldPass_OnEmptyValue3()
        {
            // Arrange
            ModelBase arg = new Model();

            // Act/Assert
            Requires.That(() => arg).IsOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue1()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue2()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsOfType on ()=>new Type() should fail.")]
        public void IsOfType_ShouldFail_OnTypeValue3()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsOfType(typeof(Model));
        }

        #endregion

        #region " IsNotOfType "

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [Description("Calling IsNotOfType on new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue1()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsNotOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [Description("Calling IsNotOfType on new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue2()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsNotOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [Description("Calling IsNotOfType on ()=>new Type() should pass.")]
        public void IsNotOfType_ShouldPass_OnTypeValue3()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsNotOfType(typeof(Model));
        }

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue1()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg).IsNotOfType(typeof(ModelBase));
        }

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue2()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(arg, "arg").IsNotOfType(typeof(ModelBase));
        }

        [TestMethod]
        [TestCategory("Class - IsNotOfType")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotOfType on ()=>Type.Empty should fail.")]
        public void IsNotOfType_ShouldFail_OnEmptyValue3()
        {
            // Arrange
            ModelBase arg = new ModelBase();

            // Act/Assert
            Requires.That(() => arg).IsNotOfType(typeof(ModelBase));
        }

        #endregion
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}