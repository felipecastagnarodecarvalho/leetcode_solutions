// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes
// the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
public class Solution {
    public int Reverse(int x) {
        var intString = x.ToString();
        var reversedIntString = "";

        var isNegative = false;

        if (intString.Contains("-")) {
            intString = intString.Replace("-", "");
            isNegative = true;
        }

        for (int i = 0; i < intString.Length; i++) {
            reversedIntString += intString[intString.Length - i - 1];
        }

        if (!int.TryParse(reversedIntString, out int number)) {
            return 0;
        }

        return isNegative ? number * -1 : number;
    }
}