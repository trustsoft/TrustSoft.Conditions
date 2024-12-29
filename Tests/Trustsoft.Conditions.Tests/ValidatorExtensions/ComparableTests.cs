//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="ComparableTests.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.Tests.ValidatorExtensions;

using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Trustsoft.Conditions.UnitTests.Helpers;

[TestClass]
public class ComparableTests
{
    #region " IsInRange "

    [TestMethod]
    [TestCategory("IComparable<T> - IsInRange")]
    [Description("Calling IsInRange on value in range should pass.")]
    public void IsInRange_ShouldPass_OnValueInRange1()
    {
        Model val = new Model(3);
        Model min = new Model(1);
        Model max = new Model(5);
        Requires.That(val).IsInRange(min, max);
        Requires.That(val, "val").IsInRange(min, max);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsInRange")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsInRange on value out of range should fail.")]
    public void IsInRange_ShouldFail_OnValueOutOfRange1()
    {
        Model val = new Model(7);
        Model min = new Model(1);
        Model max = new Model(5);
        Requires.That(val).IsInRange(min, max);
    }

    #endregion

    #region " IsNotInRange "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotInRange")]
    [Description("Calling IsNotInRange on value out of range should pass.")]
    public void IsNotInRange_ShouldPass_OnValueOtOfRange1()
    {
        Model val = new Model(7);
        Model min = new Model(1);
        Model max = new Model(5);
        Requires.That(val).IsNotInRange(min, max);
        Requires.That(val, "val").IsNotInRange(min, max);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotInRange")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotInRange on value in range should fail.")]
    public void IsNotInRange_ShouldFail_OnValueInRange1()
    {
        Model val = new Model(3);
        Model min = new Model(1);
        Model max = new Model(5);
        Requires.That(val).IsNotInRange(min, max);
    }

    #endregion

    #region " IsGreaterThan "

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterThan")]
    [Description("Calling IsGreaterThan on lower value should pass.")]
    public void IsGreaterThan_ShouldPass_OnLowerValue1()
    {
        Model val = new Model(3);
        Model min = new Model(1);
        Requires.That(val).IsGreaterThan(min);
        Requires.That(val, "val").IsGreaterThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsGreaterThan on higher value should fail.")]
    public void IsGreaterThan_ShouldFail_OnHigherValue1()
    {
        Model val = new Model(7);
        Model min = new Model(10);
        Requires.That(val).IsGreaterThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsGreaterThan on same value should fail.")]
    public void IsGreaterThan_ShouldFail_OnSameValue1()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val).IsGreaterThan(min);
    }

    #endregion

    #region " IsNotGreaterThan "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotGreaterThan")]
    [Description("Calling IsNotGreaterThan on higher value should pass.")]
    public void IsNotGreaterThan_ShouldPass_OnHigherValue()
    {
        Model val = new Model(3);
        Model max = new Model(10);
        Requires.That(val).IsNotGreaterThan(max);
        Requires.That(val, "val").IsNotGreaterThan(max);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotGreaterThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotGreaterThan on higher value should fail.")]
    public void IsNotGreaterThan_ShouldFail_OnValueInRange()
    {
        Model val = new Model(7);
        Model max = new Model(3);
        Requires.That(val).IsNotGreaterThan(max);
    }

    #endregion

    #region " IsGreaterOrEqual "

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterOrEqual")]
    [Description("Calling IsGreaterOrEqual on lower value should pass.")]
    public void IsGreaterOrEqual_ShouldPass_OnLowerValue()
    {
        Model val = new Model(3);
        Model min = new Model(1);
        Requires.That(val).IsGreaterOrEqual(min);
        Requires.That(val, "val").IsGreaterOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterOrEqual")]
    [Description("Calling IsGreaterOrEqual on same value should pass.")]
    public void IsGreaterOrEqual_ShouldPass_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val).IsGreaterOrEqual(min);
        Requires.That(val, "val").IsGreaterOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsGreaterOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsGreaterOrEqual on higher value should fail.")]
    public void IsGreaterOrEqual_ShouldFail_OnHigherValue()
    {
        Model val = new Model(7);
        Model min = new Model(10);
        Requires.That(val).IsGreaterOrEqual(min);
    }

    #endregion

    #region " IsNotGreaterOrEqual "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotGreaterOrEqual")]
    [Description("Calling IsNotGreaterOrEqual on lower value should pass.")]
    public void IsNotGreaterOrEqual_ShouldPass_OnLowerValue()
    {
        Model val = new Model(3);
        Model max = new Model(10);
        Requires.That(val).IsNotGreaterOrEqual(max);
        Requires.That(val, "val").IsNotGreaterOrEqual(max);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotGreaterOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotGreaterOrEqual on same value should fail.")]
    public void IsNotGreaterOrEqual_ShouldFail_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val, "val").IsNotGreaterOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotGreaterOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotGreaterOrEqual on lower value should fail.")]
    public void IsNotGreaterOrEqual_ShouldFail_OnHigherValue()
    {
        Model val = new Model(10);
        Model min = new Model(7);
        Requires.That(val).IsNotGreaterOrEqual(min);
    }

    #endregion

    #region " IsLessThan "

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessThan")]
    [Description("Calling IsLessThan on higher value should pass.")]
    public void IsLessThan_ShouldPass_OnHigherValue()
    {
        Model val = new Model(3);
        Model min = new Model(7);
        Requires.That(val).IsLessThan(min);
        Requires.That(val, "val").IsLessThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsLessThan on lower value should fail.")]
    public void IsLessThan_ShouldFail_OnLowerValue()
    {
        Model val = new Model(7);
        Model min = new Model(3);
        Requires.That(val).IsLessThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsLessThan on same value should fail.")]
    public void IsLessThan_ShouldFail_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val).IsLessThan(min);
    }

    #endregion

    #region " IsNotLessThan "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessThan")]
    [Description("Calling IsNotLessThan on lower value should pass.")]
    public void IsNotLessThan_ShouldPass_OnLowerValue()
    {
        Model val = new Model(7);
        Model min = new Model(5);
        Requires.That(val).IsNotLessThan(min);
        Requires.That(val, "val").IsNotLessThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessThan")]
    [Description("Calling IsNotLessThan on same value should pass.")]
    public void IsNotLessThan_ShouldPass_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val).IsNotLessThan(min);
        Requires.That(val, "val").IsNotLessThan(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessThan")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotLessThan on higher value should fail.")]
    public void IsNotLessThan_ShouldFail_OnHigherValue()
    {
        Model val = new Model(4);
        Model min = new Model(8);
        Requires.That(val).IsNotLessThan(min);
    }

    #endregion

    #region " IsLessOrEqual "

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessOrEqual")]
    [Description("Calling IsLessOrEqual on higher value should pass.")]
    public void IsLessOrEqual_ShouldPass_OnHigherValue()
    {
        Model val = new Model(3);
        Model min = new Model(10);
        Requires.That(val).IsLessOrEqual(min);
        Requires.That(val, "val").IsLessOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessOrEqual")]
    [Description("Calling IsLessOrEqual on same value should pass.")]
    public void IsLessOrEqual_ShouldPass_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val).IsLessOrEqual(min);
        Requires.That(val, "val").IsLessOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsLessOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsLessOrEqual on lower value should fail.")]
    public void IsLessOrEqual_ShouldFail_OnLowerValue()
    {
        Model val = new Model(7);
        Model min = new Model(1);
        Requires.That(val).IsLessOrEqual(min);
    }

    #endregion

    #region " IsNotLessOrEqual "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessOrEqual")]
    [Description("Calling IsNotLessOrEqual on lower value should pass.")]
    public void IsNotLessOrEqual_ShouldPass_OnLowerValue()
    {
        Model val = new Model(3);
        Model min = new Model(1);
        Requires.That(val).IsNotLessOrEqual(min);
        Requires.That(val, "val").IsNotLessOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotLessOrEqual on same value should fail.")]
    public void IsNotLessOrEqual_ShouldFail_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val, "val").IsNotLessOrEqual(min);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotLessOrEqual")]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    [Description("Calling IsNotLessOrEqual on higher value should fail.")]
    public void IsNotLessOrEqual_ShouldFail_OnHigherValue()
    {
        Model val = new Model(5);
        Model min = new Model(7);
        Requires.That(val).IsNotLessOrEqual(min);
    }

    #endregion

    #region " IsEqualTo "

    [TestMethod]
    [TestCategory("IComparable<T> - IsEqualTo")]
    [Description("Calling IsEqualTo on same value should pass.")]
    public void IsEqualTo_ShouldPass_OnSameValue()
    {
        Model val1 = new Model(7);
        Model val2 = new Model(7);
        Requires.That(val1).IsEqualTo(val2);
        Requires.That(val1, "val1").IsEqualTo(val2);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsEqualTo")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEqualTo on different value should fail.")]
    public void IsEqualTo_ShouldFail_OnDifferentValue()
    {
        Model val1 = new Model(7);
        Model val2 = new Model(10);
        Requires.That(val1).IsEqualTo(val2);
    }

    #endregion

    #region " IsNotEqualTo "

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotEqualTo")]
    [Description("Calling IsNotEqualTo on different value should pass.")]
    public void IsNotEqualTo_ShouldPass_OnDifferentValue()
    {
        Model val = new Model(3);
        Model max = new Model(10);
        Requires.That(val).IsNotEqualTo(max);
        Requires.That(val, "val").IsNotEqualTo(max);
    }

    [TestMethod]
    [TestCategory("IComparable<T> - IsNotEqualTo")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEqualTo on same value should fail.")]
    public void IsNotEqualTo_ShouldFail_OnSameValue()
    {
        Model val = new Model(7);
        Model min = new Model(7);
        Requires.That(val, "val").IsNotEqualTo(min);
    }

    #endregion
}