namespace palindromeChecker.test;

using System.Runtime.CompilerServices;
using NUnit.Framework;
using palindromeChecker.src.services;

[TestFixture]
public class PalindromeCheckerServiceTest
{
    private PalindromeCheckerService _service = new PalindromeCheckerService();
    [SetUp]
    public static void setUp()
    {
    }
    [Test]
    public void TestThatNoPalindromeIsInvalid()
    {
        var result = PalindromeCheckerService.IsValidPalindrome("Hi");
        Assert.That(result, Is.False);
    }

    [Test]
    public void TestThatPalindromeIsValid()
    {
        var result = PalindromeCheckerService.IsValidPalindrome("A man, a plan, a canal: Panama");
        Assert.That(result, Is.True);
    }

    [Test]
    public void TestThatNullIsNotValidPalindrome()
    {
        var result = PalindromeCheckerService.IsValidPalindrome(null);
        Assert.That(result, Is.False);
    }

}
