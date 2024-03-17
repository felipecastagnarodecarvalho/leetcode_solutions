// Given an integer array nums, find the subarray with the largest sum, and return its sum.
public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxCurrent = nums[0];
        int maxGlobal = nums[0];

        for (int i = 1; i < nums.Length; i++) {
            maxCurrent = Math.Max(nums[i], maxCurrent + nums[i]);
            if (maxCurrent > maxGlobal) {
                maxGlobal = maxCurrent;
            }
        }

        return maxGlobal;
    }
}