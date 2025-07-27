using LinqFilter.services.linq;
using LinqFilter.services.parsing;

namespace LinqFilter.Test;

public class LinqFilterServiceTest
{
    LinqFilterService linqFilterService = new(new ArrayParserService());

    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public void FilterEvenNumbers_ReturnsOnlyEvenNumbers()
    {
        // Arrange
        var input = new List<int> { 1, 2, 3, 4, 5, 6 };
        var expected = new List<int> { 2, 4, 6 };

        // Act
        var result = linqFilterService.FilterEvenNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FilterEvenNumbers_EmptyList_ReturnsEmptyList()
    {
        // Arrange
        var input = new List<int>();
        var expected = new List<int>();

        // Act
        var result = linqFilterService.FilterEvenNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void FilterEvenNumbers_NoEvenNumbers_ReturnsEmptyList()
    {
        // Arrange
        var input = new List<int> { 1, 3, 5, 7 };
        var expected = new List<int>();

        // Act
        var result = linqFilterService.FilterEvenNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void FilterEvenNumbers_NullInput_ThrowsArgumentNullException()
    {
        // Arrange
        List<int> input = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => linqFilterService.FilterEvenNumbers(input));
    }


}
