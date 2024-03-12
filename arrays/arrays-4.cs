// Given an integer array nums, return true if any value appears at least twice in the array,
// and return false if every element is distinct.
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var list = new List<int>();

        foreach (var num in nums) {
            if (list.Contains(num)) {
                return true;
            }
            
            list.Add(num);
        }

        return false;
    }
}