![Logo](./docs/README_Banner.png)

An extremely easy to use library that helps to check method arguments by conditions.

[GitHub repository](https://github.com/trustsoft/Trustsoft.Conditions "Visit GiHub Repository")\
![GitHub repo size](https://img.shields.io/github/repo-size/trustsoft/Trustsoft.Conditions?style=flat&logo=github&color=steelblue "Repository size")
![GitHub license](https://img.shields.io/github/license/trustsoft/Trustsoft.Conditions?style=flat&color=steelblue "Repository license")
![GitHub commit activity](https://img.shields.io/github/commit-activity/t/trustsoft/Trustsoft.Conditions?style=flat&color=steelblue "Total commits")

[![C#](https://img.shields.io/badge/C%23-gray?style=flat&logo=csharp)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![NET Standard 2.0](https://img.shields.io/badge/NET_Standard-2.0-steelblue?style=flat)](https://docs.microsoft.com/en-us/dotnet/standard/net-standard)
[![NET 5.0 - 9.0](https://img.shields.io/badge/NET-5.0_--_9.0-steelblue?style=flat)](https://learn.microsoft.com/en-us/dotnet/fundamentals/)
[![NET Framework 3.5 - 4.8](https://img.shields.io/badge/NET_FX-3.5_--_4.8-steelblue?style=flat)](https://learn.microsoft.com/en-us/dotnet/framework)

[![NuGet Stable Version (Trustsoft.Conditions)](https://img.shields.io/nuget/v/Trustsoft.Conditions.svg?label=Stable&color=steelblue)](https://www.nuget.org/packages/Trustsoft.Conditions/latest)
[![NuGet Latest Version (Trustsoft.Conditions)](https://img.shields.io/nuget/vpre/Trustsoft.Conditions.svg?label=Latest&color=peru)](https://www.nuget.org/packages/Trustsoft.Conditions/absoluteLatest )
![NuGet Downloads](https://img.shields.io/nuget/dt/Trustsoft.Conditions?color=steelblue)

## Getting Started
Install the [NuGet package](http://www.nuget.org/packages/Trustsoft.Conditions).

## Usage:
```csharp
// --- Requires.That() ---
// Requires.That will throw an exception, when some condition is not held
    
public void FirstMethod(int arg1, int arg2)
{
    // This line will throw an exception when arg1 >= arg2
    Requires.That(() => arg1).IsLessThan(arg2);
   
    // This will check that arg2
    //        - is in range 1..46
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
```
Complete list of checks:
--------------------------

The following checks are available.
New checks can be easily made by creating an extension method.

### For object:

* Evaluate
* IsNull
* IsNotNull
* IsOfType
* IsNotOfType

### For Nullable\<T\>:

* IsNull
* IsNotNull

### For Guid:

* IsEmpty
* IsNotEmpty

### For bool and bool?:

* IsTrue
* IsFalse

### For integer numeric types:

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

### For fractional numeric types:

* IsNegative, IsNotNegative
* IsPositive, IsNotPositive
* IsInRange, IsNotInRange
* IsGreaterThan, IsNotGreaterThan
* IsGreaterOrEqual, IsNotGreaterOrEqual
* IsLessThan, IsNotLessThan
* IsLessOrEqual, IsNotLessOrEqual
* IsEqualTo, IsNotEqualTo

### For string:

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

### For IComparable\<T\>:

* IsInRange, IsNotInRange
* IsGreaterThan, IsNotGreaterThan
* IsGreaterOrEqual, IsNotGreaterOrEqual
* IsLessThan, IsNotLessThan
* IsLessOrEqual, IsNotLessOrEqual
* IsEqualTo, IsNotEqualTo

### For IEnumerable and  IEnumerable\<T\>:

* IsEmpty, IsNotEmpty

## Licence

Licenced under the [MIT License](https://github.com/trustsoft/Trustsoft.Conditions/blob/main/LICENSE).