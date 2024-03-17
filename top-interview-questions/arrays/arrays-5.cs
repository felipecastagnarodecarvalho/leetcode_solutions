// Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
// You must implement a solution with a linear runtime complexity and use only constant extra space.
public class Solution {
    public int SingleNumber(int[] nums) {
        var counterDictionary = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!counterDictionary.ContainsKey(nums[i])) {
                counterDictionary.Add(nums[i], 1);
            } else {
                counterDictionary[nums[i]]++;
            }
        }
        
        return counterDictionary.Where(element => element.Value == 1).First().Key;
    }
}