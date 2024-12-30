//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IEnumerable.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>22.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions;

using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class EnumerableUnitTest
{
    #region " IsEmpty "

    [TestMethod]
    [TestCategory("IEnumerable - IsEmpty")]
    [Description("Calling IsEmpty on empty sequence should pass.")]
    public void IsEmpty_ShouldPass_OnEmptySequence()
    {
        IEnumerable seq = new int[0];

        Requires.That(seq).IsEmpty();
        Requires.That(seq, "seq").IsEmpty();
        Requires.That(() => seq).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable<T> - IsEmpty")]
    [Description("Calling IsEmpty on empty sequence should pass.")]
    public void IsEmpty_ShouldPass_OnEmptySequenceOf()
    {
        IEnumerable<int> seq = new int[0];

        Requires.That(seq).IsEmpty();
        Requires.That(seq, "seq").IsEmpty();
        Requires.That(() => seq).IsEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection - IsEmpty")]
    [Description("Calling IsEmpty on empty collection should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyCollection()
    {
        ICollection collection = new int[0];

        Requires.That(collection).IsEmpty();
        Requires.That(collection, "collection").IsEmpty();
        Requires.That(() => collection).IsEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection<T> - IsEmpty")]
    [Description("Calling IsEmpty on empty collection should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyCollectionOf()
    {
        ICollection<int> collection = new int[0];

        Requires.That(collection).IsEmpty();
        Requires.That(collection, "collection").IsEmpty();
        Requires.That(() => collection).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IList - IsEmpty")]
    [Description("Calling IsEmpty on empty list should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyList()
    {
        IList list = new int[0];

        Requires.That(list).IsEmpty();
        Requires.That(list, "list").IsEmpty();
        Requires.That(() => list).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IList<T> - IsEmpty")]
    [Description("Calling IsEmpty on empty list should pass.")]
    public void IsEmpty_ShouldPass_OnEmptyListOf()
    {
        IList<int> list = new int[0];

        Requires.That(list).IsEmpty();
        Requires.That(list, "list").IsEmpty();
        Requires.That(() => list).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty sequence should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptySequence()
    {
        IEnumerable seq = new[] { 8, 9, 0 };

        Requires.That(seq).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable<T> - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty sequence should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptySequenceOf()
    {
        IEnumerable<int> seq = new[] { 8, 9, 0 };

        Requires.That(seq, "seq").IsEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty collection should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptyCollection()
    {
        ICollection collection = new[] { 8, 9, 0 };

        Requires.That(collection).IsEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection<T> - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty collection should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptyCollectionOf()
    {
        ICollection<int> collection = new[] { 8, 9, 0 };

        Requires.That(collection, "collection").IsEmpty();
    }

    [TestMethod]
    [TestCategory("IList - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty list should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptyList()
    {
        IList list = new[] { 8, 9, 0 };

        Requires.That(() => list).IsEmpty();
    }

    [TestMethod]
    [TestCategory("IList<T> - IsEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsEmpty on non-empty list should fail.")]
    public void IsEmpty_ShouldFail_OnNonEmptyListOf()
    {
        IList<int> list = new[] { 8, 9, 0 };

        Requires.That(list, "list").IsEmpty();
    }

    #endregion

    #region " IsNotEmpty "

    [TestMethod]
    [TestCategory("IEnumerable - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty sequence should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptySequence()
    {
        IEnumerable seq = new[] { 8, 9, 10 };

        Requires.That(seq).IsNotEmpty();
        Requires.That(seq, "seq").IsNotEmpty();
        Requires.That(() => seq).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable<T> - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty sequence should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptySequenceOf()
    {
        IEnumerable<int> seq = new[] { 8, 9, 10 };

        Requires.That(seq).IsNotEmpty();
        Requires.That(seq, "seq").IsNotEmpty();
        Requires.That(() => seq).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty collection should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptyCollection()
    {
        ICollection collection = new[] { 8, 9, 10 };

        Requires.That(collection).IsNotEmpty();
        Requires.That(collection, "collection").IsNotEmpty();
        Requires.That(() => collection).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection<T> - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty collection should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptyCollectionOf()
    {
        ICollection<int> collection = new[] { 8, 9, 10 };

        Requires.That(collection).IsNotEmpty();
        Requires.That(collection, "collection").IsNotEmpty();
        Requires.That(() => collection).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IList - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty list should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptyList()
    {
        IList list = new[] { 8, 9, 10 };

        Requires.That(list).IsNotEmpty();
        Requires.That(list, "list").IsNotEmpty();
        Requires.That(() => list).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IList<T> - IsNotEmpty")]
    [Description("Calling IsNotEmpty on non-empty list should pass.")]
    public void IsNotEmpty_ShouldPass_OnEmptyListOf()
    {
        IList<int> list = new[] { 8, 9, 10 };

        Requires.That(list).IsNotEmpty();
        Requires.That(list, "list").IsNotEmpty();
        Requires.That(() => list).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty sequence should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptySequence()
    {
        IEnumerable seq = new int[0];

        Requires.That(seq).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IEnumerable<T> - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty sequence should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptySequenceOf()
    {
        IEnumerable<int> seq = new int[0];

        Requires.That(seq, "seq").IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty collection should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptyCollection()
    {
        ICollection collection = new int[0];

        Requires.That(collection).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("ICollection<T> - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty collection should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptyCollectionOf()
    {
        ICollection<int> collection = new int[0];

        Requires.That(collection, "collection").IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IList - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty list should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptyList()
    {
        IList list = new int[0];

        Requires.That(() => list).IsNotEmpty();
    }

    [TestMethod]
    [TestCategory("IList<T> - IsNotEmpty")]
    [ExpectedException(typeof(ArgumentException))]
    [Description("Calling IsNotEmpty on empty list should fail.")]
    public void IsNotEmpty_ShouldFail_OnNonEmptyListOf()
    {
        IList<int> list = new int[0];

        Requires.That(list, "list").IsNotEmpty();
    }

    #endregion
}