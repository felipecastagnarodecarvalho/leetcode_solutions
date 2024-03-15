// Write a function that reverses a string. The input string is given as an array of characters s.
// You must do this by modifying the input array in-place with O(1) extra memory.
public class Solution {
    public void ReverseString(char[] s) {
        var originalList = new List<char>(s);
        var original = originalList.ToArray();

        for (int i = 0; i < s.Length; i++) {
            s[i] = original[s.Length - i - 1];
        }
    }
}