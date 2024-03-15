// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric
// characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.
using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        var lowercaseString = s.ToLower();
        var cleanString = Regex.Replace(lowercaseString, "[^a-zA-Z0-9]", "");
        var newString = "";
        
        for(int i = 0; i < cleanString.Length; i++) {
            newString += cleanString[cleanString.Length - i - 1];
        }

        if (cleanString == newString) {
            return true;
        }

        return false;
    }
}