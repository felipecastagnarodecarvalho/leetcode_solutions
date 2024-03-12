// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word
// or phrase, typically using all the original letters exactly once.
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }

        var sFrequency = new Dictionary<char,int>();
        
        foreach (var c in s) {
            if (!sFrequency.ContainsKey(c)) {
                sFrequency.Add(c, 1);
            } else {
                sFrequency[c]++;
            }
        }

        var tFrequency = new Dictionary<char,int>();

        foreach (var c in t) {
            if (!tFrequency.ContainsKey(c)) {
                tFrequency.Add(c, 1);
            } else {
                tFrequency[c]++;
            }
        }

        foreach (var keyValuePair in tFrequency) {
            if (!sFrequency.ContainsKey(keyValuePair.Key)) {
                return false;
            }
            if (sFrequency[keyValuePair.Key] != keyValuePair.Value) {
                return false;
            }
        }
        
        return true;
    }
}