using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace palindromeChecker.src.services
{
    public partial class PalindromeCheckerService
    {
        [GeneratedRegex(@"[^a-zA-Z0-9]")]
        private static partial Regex IsNotSpecialCharacterOrWhiteSpace();
        public static Boolean IsValidPalindrome(string? input)
        {
            if (input != null)
            {
                var trimmedToLower = IsNotSpecialCharacterOrWhiteSpace().Replace(input, "").ToLower();
                char[] charArary = trimmedToLower.ToCharArray();
                Array.Reverse(charArary);
                var reversed = new string(charArary);
                return String.Equals(reversed, trimmedToLower);
            }
            return false;
        }
    
    }
}