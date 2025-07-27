namespace LinqFilter.Test;
using LinqFilter.services.parsing;
public class ArrayParserServiceTest
{
    ArrayParserService service = new ArrayParserService();
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ParseToIntArray_ReturnsCorrectIntList()
    {
        // Arrange
        var input = "1,2,3,4,5";

        // Act
        List<int> result = service.ParseToIntArray(input);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3, 4, 5 }), "Expect to contain all passed value as an entry");
            Assert.That(result.Count, Is.EqualTo(5), "5 entries are passed so we expect the size to be 5");
        });
    }

    [Test]
    public void ParseToIntArray_EmptyString_ReturnsEmptyList()
    {
        // Arrange
        var input = "";
        // Act
        var result = service.ParseToIntArray(input);
        // Assert
        Assert.That(result, Is.Empty, "Empty string should return an empty list");
    }

    [Test]
    public void ParseToIntArray_SingleValue_ReturnsSingleElementList()
    {
        // Arrange
        var input = "42";
        // Act
        var result = service.ParseToIntArray(input);
        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 42 }), "Single value should return a list with one element");
    }

    [Test]
    public void ParseToIntArray_ValuesWithSpaces_ReturnsTrimmedIntList()
    {
        // Arrange
        var input = " 7, 8 , 9 ";
        // Act
        var result = service.ParseToIntArray(input);
        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 7, 8, 9 }), "Values with spaces should be trimmed and parsed correctly");
    }

    [Test]
    public void ParseToIntArray_NegativeAndZeroValues_ReturnsCorrectList()
    {
        // Arrange
        var input = "-1,0,2";
        // Act
        var result = service.ParseToIntArray(input);
        // Assert
        Assert.That(result, Is.EqualTo(new int[] { -1, 0, 2 }), "Negative and zero values should be parsed correctly");
    }

    [Test]
    public void ParseToIntArray_InvalidNumbers_ThrowsFormatException()
    {
        // Arrange
        var input = "1,abc,3";
        // Act & Assert
        Assert.DoesNotThrow(() => service.ParseToIntArray(input), "Invalid numbers should throw FormatException");
    }

    [Test]
    public void ParseToIntArray_ExtraCommas_IgnoresEmptyEntries()
    {
        // Arrange
        var input = "1,,2,3,";
        // Act
        var result = service.ParseToIntArray(input);
        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3 }), "Extra commas should be ignored");
    }



}
