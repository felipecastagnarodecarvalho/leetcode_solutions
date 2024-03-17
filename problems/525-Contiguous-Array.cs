// Given a binary array nums, return the maximum length of a contiguous subarray with an equal number of 0 and 1.
public class Solution {
    public int FindMaxLength(int[] nums) {
        // This dictionary will store the count at each index
        Dictionary<int, int> countAtIndex = new Dictionary<int, int>();
        int maxLength = 0;
        int count = 0; // This count changes by -1 for '0' and by +1 for '1'

        // Initialize with count 0 at index -1 to handle the case when subarray starts from index 0
        countAtIndex.Add(0, -1);

        for (int i = 0; i < nums.Length; i++) {
            // Change count according to the value of nums[i]
            count += nums[i] == 0 ? -1 : 1;

            // If this count has been seen before, we have found a subarray with equal number of 0's and 1's
            if (countAtIndex.ContainsKey(count)) {
                maxLength = Math.Max(maxLength, i - countAtIndex[count]);
            } else {
                countAtIndex.Add(count, i);
            }
        }

        return maxLength;
    }
}