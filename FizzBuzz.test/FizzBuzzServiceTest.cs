
using NUnit.Framework;
using fizzBuzz;
[TestFixture]
public class FizzBuzzServiceTest
{
    [SetUp]
    public static void SetUp()
    {
    }
    [TestCase(1, 3,false)]
    [TestCase(3, 3,true)]
    [TestCase(1, 5, false)]
    [TestCase(5, 5, true)]
    public void DividableByReturns_Expected_For_Number_And_Divider(int number,int divider ,Boolean expected)
    {
        var result = FizzBuzzService.IsDividableBy(number, divider);
        Assert.That(result, Is.EqualTo(expected));
    }
}

