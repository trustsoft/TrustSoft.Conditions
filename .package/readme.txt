Welcome to Trustsoft.Conditions Library.

An extremely easy to use library that helps to check method arguments by conditions.

Need more checks?? Let me know.

Usage:
// --- Requires.That() ---
// Requires.That will throw an exception, when some condition is not met

public void FirstMethod(int arg1, int arg2)
{
    // This line will throw an exception when arg1 >= arg2
    Requires.That(() => arg1).IsLessThan(arg2);

    // This will check that arg2
    //      - is not null
    //      - is in range 1..46
    Requires.That(arg2, "arg2").IsNotNull().IsInRange(1,46);

    // Several checks can be added.
    Requires.That(arg1).IsInRange(100,1000).IsEven().IsTrue(x => x > 50, "Must be over 500");

    // Do something
}