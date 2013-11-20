//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Int32.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2013 Trustsoft Ltd. All rights reserved.------------------------

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
    public class Int32UnitTest
    {
        #region " IsInRange "

        [TestMethod]
        [TestCategory("Int32 - IsInRange")]
        [Description("Calling IsInRange on value in range should pass.")]
        public void IsInRange_ShouldPassOnValueInRange1()
        {
            int val = 3;
            int min = 1;
            int max = 5;
            Requires.That(val).IsInRange(min, max);
            Requires.That(val, "val").IsInRange(min, max);
        }

        [TestMethod]
        [TestCategory("Int32 - IsInRange")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsInRange on value out of range should fail.")]
        public void IsInRange_ShouldFailOnValueOutOfRange1()
        {
            int val = 7;
            int min = 1;
            int max = 5;
            Requires.That(val).IsInRange(min, max);
        }

        #endregion

        #region " IsNotInRange "

        [TestMethod]
        [TestCategory("Int32 - IsNotInRange")]
        [Description("Calling IsNotInRange on value out of range should pass.")]
        public void IsNotInRange_ShouldPassOnValueOtOfRange1()
        {
            int val = 7;
            int min = 1;
            int max = 5;
            Requires.That(val).IsNotInRange(min, max);
            Requires.That(val, "val").IsNotInRange(min, max);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotInRange")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotInRange on value in range should fail.")]
        public void IsNotInRange_ShouldFailOnValueInRange1()
        {
            int val = 3;
            int min = 1;
            int max = 5;
            Requires.That(val).IsNotInRange(min, max);
        }

        #endregion

        #region " IsGreaterThan "

        [TestMethod]
        [TestCategory("Int32 - IsGreaterThan")]
        [Description("Calling IsGreaterThan on lower value should pass.")]
        public void IsGreaterThan_ShouldPassOnLowerValue1()
        {
            int val = 3;
            int min = 1;
            Requires.That(val).IsGreaterThan(min);
            Requires.That(val, "val").IsGreaterThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsGreaterThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsGreaterThan on higher value should fail.")]
        public void IsGreaterThan_ShouldFailOnHigherValue1()
        {
            int val = 7;
            int min = 10;
            Requires.That(val).IsGreaterThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsGreaterThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsGreaterThan on same value should fail.")]
        public void IsGreaterThan_ShouldFailOnSameValue1()
        {
            int val = 7;
            int min = 7;
            Requires.That(val).IsGreaterThan(min);
        }

        #endregion

        #region " IsNotGreaterThan "

        [TestMethod]
        [TestCategory("Int32 - IsNotGreaterThan")]
        [Description("Calling IsNotGreaterThan on higher value should pass.")]
        public void IsNotGreaterThan_ShouldPassOnHigherValue()
        {
            int val = 3;
            int max = 10;
            Requires.That(val).IsNotGreaterThan(max);
            Requires.That(val, "val").IsNotGreaterThan(max);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotGreaterThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotGreaterThan on higher value should fail.")]
        public void IsNotGreaterThan_ShouldFailOnValueInRange()
        {
            int val = 7;
            int max = 3;
            Requires.That(val).IsNotGreaterThan(max);
        }

        #endregion

        #region " IsGreaterOrEqual "

        [TestMethod]
        [TestCategory("Int32 - IsGreaterOrEqual")]
        [Description("Calling IsGreaterOrEqual on lower value should pass.")]
        public void IsGreaterOrEqual_ShouldPassOnLowerValue()
        {
            int val = 3;
            int min = 1;
            Requires.That(val).IsGreaterOrEqual(min);
            Requires.That(val, "val").IsGreaterOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsGreaterOrEqual")]
        [Description("Calling IsGreaterOrEqual on same value should pass.")]
        public void IsGreaterOrEqual_ShouldPassOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val).IsGreaterOrEqual(min);
            Requires.That(val, "val").IsGreaterOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsGreaterOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsGreaterOrEqual on higher value should fail.")]
        public void IsGreaterOrEqual_ShouldFailOnHigherValue()
        {
            int val = 7;
            int min = 10;
            Requires.That(val).IsGreaterOrEqual(min);
        }

        #endregion

        #region " IsNotGreaterOrEqual "

        [TestMethod]
        [TestCategory("Int32 - IsNotGreaterOrEqual")]
        [Description("Calling IsNotGreaterOrEqual on lower value should pass.")]
        public void IsNotGreaterOrEqual_ShouldPassOnLowerValue()
        {
            int val = 3;
            int max = 10;
            Requires.That(val).IsNotGreaterOrEqual(max);
            Requires.That(val, "val").IsNotGreaterOrEqual(max);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotGreaterOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotGreaterOrEqual on same value should fail.")]
        public void IsNotGreaterOrEqual_ShouldFailOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val, "val").IsNotGreaterOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotGreaterOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotGreaterOrEqual on lower value should fail.")]
        public void IsNotGreaterOrEqual_ShouldFailOnHigherValue()
        {
            int val = 10;
            int min = 7;
            Requires.That(val).IsNotGreaterOrEqual(min);
        }

        #endregion

        #region " IsLessThan "

        [TestMethod]
        [TestCategory("Int32 - IsLessThan")]
        [Description("Calling IsLessThan on higher value should pass.")]
        public void IsLessThan_ShouldPassOnHigherValue()
        {
            int val = 3;
            int min = 7;
            Requires.That(val).IsLessThan(min);
            Requires.That(val, "val").IsLessThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsLessThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsLessThan on lower value should fail.")]
        public void IsLessThan_ShouldFailOnLowerValue()
        {
            int val = 7;
            int min = 3;
            Requires.That(val).IsLessThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsLessThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsLessThan on same value should fail.")]
        public void IsLessThan_ShouldFailOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val).IsLessThan(min);
        }

        #endregion

        #region " IsNotLessThan "

        [TestMethod]
        [TestCategory("Int32 - IsNotLessThan")]
        [Description("Calling IsNotLessThan on lower value should pass.")]
        public void IsNotLessThan_ShouldPassOnLowerValue()
        {
            int val = 7;
            int min = 5;
            Requires.That(val).IsNotLessThan(min);
            Requires.That(val, "val").IsNotLessThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotLessThan")]
        [Description("Calling IsNotLessThan on same value should pass.")]
        public void IsNotLessThan_ShouldPassOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val).IsNotLessThan(min);
            Requires.That(val, "val").IsNotLessThan(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotLessThan")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotLessThan on higher value should fail.")]
        public void IsNotLessThan_ShouldFailOnHigherValue()
        {
            int val = 4;
            int min = 8;
            Requires.That(val).IsNotLessThan(min);
        }

        #endregion

        #region " IsLessOrEqual "

        [TestMethod]
        [TestCategory("Int32 - IsLessOrEqual")]
        [Description("Calling IsLessOrEqual on higher value should pass.")]
        public void IsLessOrEqual_ShouldPassOnHigherValue()
        {
            int val = 3;
            int min = 10;
            Requires.That(val).IsLessOrEqual(min);
            Requires.That(val, "val").IsLessOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsLessOrEqual")]
        [Description("Calling IsLessOrEqual on same value should pass.")]
        public void IsLessOrEqual_ShouldPassOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val).IsLessOrEqual(min);
            Requires.That(val, "val").IsLessOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsLessOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsLessOrEqual on lower value should fail.")]
        public void IsLessOrEqual_ShouldFailOnLowerValue()
        {
            int val = 7;
            int min = 1;
            Requires.That(val).IsLessOrEqual(min);
        }

        #endregion

        #region " IsNotLessOrEqual "

        [TestMethod]
        [TestCategory("Int32 - IsNotLessOrEqual")]
        [Description("Calling IsNotLessOrEqual on lower value should pass.")]
        public void IsNotLessOrEqual_ShouldPassOnLowerValue()
        {
            int val = 3;
            int min = 1;
            Requires.That(val).IsNotLessOrEqual(min);
            Requires.That(val, "val").IsNotLessOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotLessOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotLessOrEqual on same value should fail.")]
        public void IsNotLessOrEqual_ShouldFailOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val, "val").IsNotLessOrEqual(min);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotLessOrEqual")]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [Description("Calling IsNotLessOrEqual on higher value should fail.")]
        public void IsNotLessOrEqual_ShouldFailOnHigherValue()
        {
            int val = 5;
            int min = 7;
            Requires.That(val).IsNotLessOrEqual(min);
        }

        #endregion

        #region " IsEqualTo "

        [TestMethod]
        [TestCategory("Int32 - IsEqualTo")]
        [Description("Calling IsEqualTo on same value should pass.")]
        public void IsEqualTo_ShouldPassOnSameValue()
        {
            int val1 = 7;
            int val2 = 7;
            Requires.That(val1).IsEqualTo(val2);
            Requires.That(val1, "val1").IsEqualTo(val2);
        }

        [TestMethod]
        [TestCategory("Int32 - IsEqualTo")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEqualTo on different value should fail.")]
        public void IsEqualTo_ShouldFailOnDifferentValue()
        {
            int val1 = 7;
            int val2 = 10;
            Requires.That(val1).IsEqualTo(val2);
        }

        #endregion

        #region " IsNotEqualTo "

        [TestMethod]
        [TestCategory("Int32 - IsNotEqualTo")]
        [Description("Calling IsNotEqualTo on different value should pass.")]
        public void IsNotEqualTo_ShouldPassOnDifferentValue()
        {
            int val = 3;
            int max = 10;
            Requires.That(val).IsNotEqualTo(max);
            Requires.That(val, "val").IsNotEqualTo(max);
        }

        [TestMethod]
        [TestCategory("Int32 - IsNotEqualTo")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEqualTo on same value should fail.")]
        public void IsNotEqualTo_ShouldFailOnSameValue()
        {
            int val = 7;
            int min = 7;
            Requires.That(val, "val").IsNotEqualTo(min);
        }

        #endregion
    }

    // ReSharper restore ConditionIsAlwaysTrueOrFalse
    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}