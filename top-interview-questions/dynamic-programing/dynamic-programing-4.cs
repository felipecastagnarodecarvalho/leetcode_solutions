// You are a professional robber planning to rob houses along a street. Each house has
// a certain amount of money stashed, the only constraint stopping you from robbing each
// of them is that adjacent houses have security systems connected and it will automatically
// contact the police if two adjacent houses were broken into on the same night.
// Given an integer array nums representing the amount of money of each house, return the maximum
// amount of money you can rob tonight without alerting the police.
public class Solution {
    public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0) {
            return 0;
        }
        
        if(nums.Length == 1) {
            return nums[0];
        }
        
        // Initialize an array to store the max value robbed up to each house
        int[] dp = new int[nums.Length];
        dp[0] = nums[0];
        dp[1] = Math.Max(nums[0], nums[1]);

        // Fill in the dp array
        for(int i = 2; i < nums.Length; i++) {
            dp[i] = Math.Max(dp[i - 1], nums[i] + dp[i - 2]);
        }
        
        // The last element of dp represents the maximum amount that can be robbed
        return dp[nums.Length - 1];    
    }
}