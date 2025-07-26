namespace palindromeChecker.test;

using System;
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
    
    [TestCase("HI", false)]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase(null,false)]
    public void TestIsValidPalindrome(string? palindrome, Boolean expected)
    {
        var result = PalindromeCheckerService.IsValidPalindrome(palindrome);
        Assert.That(result, Is.EqualTo(expected));
    }

}
