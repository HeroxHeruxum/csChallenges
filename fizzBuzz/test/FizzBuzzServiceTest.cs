
using NUnit.Framework;
using services;

[TestFixture]
public class FizzBuzzServiceTest
{
    [SetUp]
    public static void SetUp()
    {
    }
    [TestCase(1, false)]
    [TestCase(3, true)]
    public void TestThatIsDivedableBy3(int number, Boolean expected)
    {
        var result = FizzBuzzService.IsDividableBy3(3);
        Assert.That(result, Is.EqualTo(expected));
    }
}

