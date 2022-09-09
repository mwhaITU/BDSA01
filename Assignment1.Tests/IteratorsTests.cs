namespace Assignment1.Tests;

using Xunit;

public class IteratorsTests
{
    [Fact]
    public void Filter_returns_2_and_4_when_given_12345_with_even_predicate() {
        Iterators.Filter<int> filter = new Iterators.Filter<int>();
    }
}