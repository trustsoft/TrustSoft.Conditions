Trustsoft.Conditions
====================

### An extremely easy to use library that helps to check method arguments by conditions.

If you need more checks?? Just let me know.

Usage:
-----------------------------------------------------------------------------------
	
	// --- Requires.That() ---
	// Requires.That will throw an exception, when some condition is not met

	public void FirstMethod(int arg1, int arg2)
	{
		// This line will throw an exception when arg1 >= arg2
		Requires.That(() => arg1).IsLessThan(arg2);

		// This will check that arg2
		//		- is in range 1..46
		Requires.That(arg2, "arg2").IsInRange(1,46);

		// Several checks can be added.
		Requires.That(arg1).IsInRange(100,1000).IsEven().IsTrue(x => x > 50, "Must be over 500");

		// Do something
	}

	// --- Validate.That() ---
	// Validate.That makes possible to get a list of all error conditions

	public void SecondMethod(string arg1)
	{
		// Get a list of errors
		IEnumerable<KeyValuePair<ViolationType, string>> errors = Validate.That(() => arg1).IsNotNull().GetErrors();
	}


Complete list of checks:
--------------------------

The following checks are available.
New checks can easily be made by creating an extension method.

For object:

* Evaluate
* IsNull
* IsNotNull
* IsOfType
* IsNotOfType

For Nullable<T>:

* IsNull
* IsNotNull

For Guid:

* IsEmpty
* IsNotEmpty

For bool and bool?:

* IsTrue
* IsFalse

For int and long (and other numeric types):

* IsNegative, IsNotNegative
* IsPositive, IsNotPositive
* IsInRange, IsNotInRange
* IsGreaterThan, IsNotGreaterThan
* IsGreaterOrEqual, IsNotGreaterOrEqual
* IsLessThan, IsNotLessThan
* IsLessOrEqual, IsNotLessOrEqual
* IsEqualTo, IsNotEqualTo
* IsOdd
* IsEven

For string:

* Contains, DoesNotContain
* IsMatch, IsNotMatch
* IsEmpty, IsNotEmpty
* IsNullOrEmpty, IsNotNullOrEmpty
* IsNullOrWhiteSpace, IsNotNullOrWhiteSpace
* StartsWith, DoesNotStartWith
* EndsWith, DoesNotEndWith
* HasLength, DoesNotHaveLength
* IsShorterThan, IsShorterOrEqual
* IsLongerThan, IsLongerOrEqual

For IComparable (Int32, Double, String, Char, DateTime and other classes implementing the interface)

* IsInRange, IsNotInRange
* IsGreaterThan, IsNotGreaterThan
* IsGreaterOrEqual, IsNotGreaterOrEqual
* IsLessThan, IsNotLessThan
* IsLessOrEqual, IsNotLessOrEqual
* IsEqualTo, IsNotEqualTo

For IEnumerable:

* IsEmpty, IsNotEmpty

#### Not yet implemented: ####

For IEnumerable:

* Length
* Contains