//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="IEnumerable.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>22.11.2013</date>
//------------------------Copyright © 2012-2014 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;
    using System.Collections;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ConvertToConstant.Local

    [TestClass]
    public class IEnumerableUnitTest
    {
        #region " IsEmpty "

        [TestMethod]
        [TestCategory("IEnumerable - IsEmpty")]
        [Description("Calling IsEmpty on empty sequence should pass.")]
        public void IsEmpty_ShouldPassOnEmptySequence()
        {
            IEnumerable seq = new int[0];

            Requires.That(seq).IsEmpty();
            Requires.That(seq, "seq").IsEmpty();
            Requires.That(() => seq).IsEmpty();
        }

        [TestMethod]
        [TestCategory("IEnumerable<T> - IsEmpty")]
        [Description("Calling IsEmpty on empty sequence should pass.")]
        public void IsEmpty_ShouldPassOnEmptySequenceOf()
        {
            IEnumerable<int> seq = new int[0];

            Requires.That(seq).IsEmpty();
            Requires.That(seq, "seq").IsEmpty();
            Requires.That(() => seq).IsEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection - IsEmpty")]
        [Description("Calling IsEmpty on empty collection should pass.")]
        public void IsEmpty_ShouldPassOnEmptyCollection()
        {
            ICollection collection = new int[0];

            Requires.That(collection).IsEmpty();
            Requires.That(collection, "collection").IsEmpty();
            Requires.That(() => collection).IsEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection<T> - IsEmpty")]
        [Description("Calling IsEmpty on empty collection should pass.")]
        public void IsEmpty_ShouldPassOnEmptyCollectionOf()
        {
            ICollection<int> collection = new int[0];

            Requires.That(collection).IsEmpty();
            Requires.That(collection, "collection").IsEmpty();
            Requires.That(() => collection).IsEmpty();
        }

        [TestMethod]
        [TestCategory("IList - IsEmpty")]
        [Description("Calling IsEmpty on empty list should pass.")]
        public void IsEmpty_ShouldPassOnEmptyList()
        {
            IList list = new int[0];

            Requires.That(list).IsEmpty();
            Requires.That(list, "list").IsEmpty();
            Requires.That(() => list).IsEmpty();
        }

        [TestMethod]
        [TestCategory("IList<T> - IsEmpty")]
        [Description("Calling IsEmpty on empty list should pass.")]
        public void IsEmpty_ShouldPassOnEmptyListOf()
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
        public void IsEmpty_ShouldFailOnNonEmptySequence()
        {
            IEnumerable seq = new[] { 8, 9, 0 };

            Requires.That(seq).IsEmpty();
        }

        [TestMethod]
        [TestCategory("IEnumerable<T> - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-empty sequence should fail.")]
        public void IsEmpty_ShouldFailOnNonEmptySequenceOf()
        {
            IEnumerable<int> seq = new[] { 8, 9, 0 };

            Requires.That(seq, "seq").IsEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-empty collection should fail.")]
        public void IsEmpty_ShouldFailOnNonEmptyCollection()
        {
            ICollection collection = new[] { 8, 9, 0 };

            Requires.That(collection).IsEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection<T> - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-empty collection should fail.")]
        public void IsEmpty_ShouldFailOnNonEmptyCollectionOf()
        {
            ICollection<int> collection = new[] { 8, 9, 0 };

            Requires.That(collection, "collection").IsEmpty();
        }

        [TestMethod]
        [TestCategory("IList - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-empty list should fail.")]
        public void IsEmpty_ShouldFailOnNonEmptyList()
        {
            IList list = new[] { 8, 9, 0 };

            Requires.That(() => list).IsEmpty();
        }

        [TestMethod]
        [TestCategory("IList<T> - IsEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsEmpty on non-empty list should fail.")]
        public void IsEmpty_ShouldFailOnNonEmptyListOf()
        {
            IList<int> list = new[] { 8, 9, 0 };

            Requires.That(list, "list").IsEmpty();
        }

        #endregion

        #region " IsNotEmpty "

        [TestMethod]
        [TestCategory("IEnumerable - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty sequence should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptySequence()
        {
            IEnumerable seq = new[] { 8, 9, 10 };

            Requires.That(seq).IsNotEmpty();
            Requires.That(seq, "seq").IsNotEmpty();
            Requires.That(() => seq).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IEnumerable<T> - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty sequence should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptySequenceOf()
        {
            IEnumerable<int> seq = new[] { 8, 9, 10 };

            Requires.That(seq).IsNotEmpty();
            Requires.That(seq, "seq").IsNotEmpty();
            Requires.That(() => seq).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty collection should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptyCollection()
        {
            ICollection collection = new[] { 8, 9, 10 };

            Requires.That(collection).IsNotEmpty();
            Requires.That(collection, "collection").IsNotEmpty();
            Requires.That(() => collection).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection<T> - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty collection should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptyCollectionOf()
        {
            ICollection<int> collection = new[] { 8, 9, 10 };

            Requires.That(collection).IsNotEmpty();
            Requires.That(collection, "collection").IsNotEmpty();
            Requires.That(() => collection).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IList - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty list should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptyList()
        {
            IList list = new[] { 8, 9, 10 };

            Requires.That(list).IsNotEmpty();
            Requires.That(list, "list").IsNotEmpty();
            Requires.That(() => list).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IList<T> - IsNotEmpty")]
        [Description("Calling IsNotEmpty on non-empty list should pass.")]
        public void IsNotEmpty_ShouldPassOnEmptyListOf()
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
        public void IsNotEmpty_ShouldFailOnNonEmptySequence()
        {
            IEnumerable seq = new int[0];

            Requires.That(seq).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IEnumerable<T> - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on empty sequence should fail.")]
        public void IsNotEmpty_ShouldFailOnNonEmptySequenceOf()
        {
            IEnumerable<int> seq = new int[0];

            Requires.That(seq, "seq").IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on empty collection should fail.")]
        public void IsNotEmpty_ShouldFailOnNonEmptyCollection()
        {
            ICollection collection = new int[0];

            Requires.That(collection).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("ICollection<T> - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on empty collection should fail.")]
        public void IsNotEmpty_ShouldFailOnNonEmptyCollectionOf()
        {
            ICollection<int> collection = new int[0];

            Requires.That(collection, "collection").IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IList - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on empty list should fail.")]
        public void IsNotEmpty_ShouldFailOnNonEmptyList()
        {
            IList list = new int[0];

            Requires.That(() => list).IsNotEmpty();
        }

        [TestMethod]
        [TestCategory("IList<T> - IsNotEmpty")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling IsNotEmpty on empty list should fail.")]
        public void IsNotEmpty_ShouldFailOnNonEmptyListOf()
        {
            IList<int> list = new int[0];

            Requires.That(list, "list").IsNotEmpty();
        }

        #endregion
    }

    // ReSharper restore ConvertToConstant.Local
    // ReSharper restore InconsistentNaming
}