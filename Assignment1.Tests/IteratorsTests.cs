namespace Assignment1.Tests;
using Xunit;

public class IteratorsTests
{
    [Fact]
    public void filter_should_return_2_and_4_given_12345_with_even_predicate() {
        // Arrange
        var list = new List<int>() { 1, 2, 3, 4, 5 };
        Predicate<int> even = Even;
        bool Even(int i) => i % 2 == 0;

        // Act
        var actual = Iterators.Filter<int>(list, even);

        // Assert
        Assert.Equal(new List<int> { 2, 4 }, actual);
    }
}