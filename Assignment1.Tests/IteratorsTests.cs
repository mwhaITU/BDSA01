namespace Assignment1.Tests;
using Xunit;
using FluentAssertions;

public class IteratorsTests
{

    [Fact]
    public void flatten_should_return_single_stream_of_t()
    {
        //Arrange
        var innerlist1 = new List<int>() { 1, 2, 3, 4, 5 };
        var innerlist2 = new List<int>() { 1, 2, 3, 4, 5 };
        var list1 = new List<IEnumerable<int>>() { innerlist1, innerlist2 };

        //Act
        var actual = Iterators.Flatten(list1);
        //Assert
        actual.Should().BeEquivalentTo(new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 });
    }
}