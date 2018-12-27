//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------
// <copyright file="Evaluate.UnitTest.cs" company="Trustsoft Ltd.">
//     Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.
// </copyright>
// <date>20.11.2013</date>
//------------------------Copyright © 2012-2018 Trustsoft Ltd. All rights reserved.------------------------

namespace Trustsoft.Conditions.UnitTests.ValidatorExtensions
{
    #region " Using Directives "

    using System;
    using System.Linq.Expressions;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    // ReSharper disable InconsistentNaming
    // ReSharper disable ExpressionIsAlwaysNull

    [TestClass]
    public class EvaluateUnitTest
    {
        [TestMethod]
        [TestCategory("Evaluate")]
        [Description("Calling Evaluate on 123 with expression 'x => x == 123' should pass.")]
        public void Evaluate_ShouldPass_OnExpressionValue()
        {
            int a = 123;
            Expression<Func<int, bool>> expression = x => x == 123;
            Requires.That(a).Evaluate(expression);
        }

        [TestMethod]
        [TestCategory("Evaluate")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling Evaluate on 33 with expression '(x) => (x == 444)' should fail.")]
        public void Evaluate_ShouldFail_OnExpressionValue()
        {
            int a = 33;
            Requires.That(a).Evaluate(x => x == 444);
        }

        [TestMethod]
        [TestCategory("Evaluate")]
        [Description("Calling Evaluate on object x with expression 'x => true' should pass.")]
        public void Evaluate_ShouldPass_OnObjectWithExpression()
        {
            object a = new object();
            Requires.That(a).Evaluate(x => true);
        }

        [TestMethod]
        [TestCategory("Evaluate")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling Evaluate on null object x with expression 'x => x != null' should fail.")]
        public void Evaluate_ShouldFail_OnNullWithExpression1()
        {
            object a = null;
            Requires.That(a).Evaluate(x => x != null);
        }

        [TestMethod]
        [TestCategory("Evaluate")]
        [ExpectedException(typeof(ArgumentNullException))]
        [Description("Calling Evaluate on null object x with expression 'x => x == 3' should fail.")]
        public void Evaluate_ShouldFail_OnNullWithExpression2()
        {
            int? a = null;
            Requires.That(a).Evaluate(x => x == 3);
        }

        [TestMethod]
        [TestCategory("Evaluate")]
        [ExpectedException(typeof(ArgumentException))]
        [Description("Calling Evaluate with 'null' should fail.")]
        public void Evaluate_ShouldFail_OnValueWithNull()
        {
            Requires.That(3).Evaluate(null);
        }
    }

    // ReSharper restore ExpressionIsAlwaysNull
    // ReSharper restore InconsistentNaming
}