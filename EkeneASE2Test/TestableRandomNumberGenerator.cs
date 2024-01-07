/// <summary>
/// A testable implementation of the IRandomNumberGenerator interface that returns a fixed value.
/// This class is useful for unit testing scenarios where predictable output is required.
/// </summary>
public class TestableRandomNumberGenerator : IRandomNumberGenerator
{
    // A fixed value that this testable random number generator will always return.
    private int _fixedValue;

    /// <summary>
    /// Initializes a new instance of the TestableRandomNumberGenerator class with a specified fixed value.
    /// </summary>
    /// <param name="fixedValue">The fixed value to be returned by the Next method.</param>
    public TestableRandomNumberGenerator(int fixedValue)
    {
        _fixedValue = fixedValue;
    }

    /// <summary>
    /// Returns the fixed value set during initialization, ignoring the provided min and max parameters.
    /// </summary>
    /// <param name="minValue">The inclusive lower bound of the random number returned (ignored in this implementation).</param>
    /// <param name="maxValue">The exclusive upper bound of the random number returned (ignored in this implementation).</param>
    /// <returns>The fixed value set during the initialization of this instance.</returns>
    public int Next(int minValue, int maxValue)
    {
        // Ignores the minValue and maxValue parameters and always returns the fixed value.
        return _fixedValue;
    }
}
