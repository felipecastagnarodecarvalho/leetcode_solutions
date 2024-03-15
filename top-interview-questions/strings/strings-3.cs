// Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
public class Solution {
    public int FirstUniqChar(string s) {
        var frequency = new Dictionary<char, int>();

        foreach(char c in s) {
            if(frequency.ContainsKey(c)) {
                frequency[c]++;
            } else {
                frequency[c] = 1;
            }
        }

        for(int i = 0; i < s.Length; i++) {
            if(frequency[s[i]] == 1) {
                return i;
            }
        }
        
        return -1;
    }
}