// Given a binary array nums and an integer goal, return the number of non-empty subarrays with a sum goal.
// A subarray is a contiguous part of the array.
public class Solution {
    private List<int[]> sumList = new List<int[]>();

    public int NumSubarraysWithSum(int[] nums, int goal) {
        int count = 0;
        int sum = 0;
        Dictionary<int, int> sumOccurrences = new Dictionary<int, int>();
        sumOccurrences[0] = 1;

        foreach (int num in nums) {
            sum += num;

            if (sumOccurrences.ContainsKey(sum - goal)) {
                count += sumOccurrences[sum - goal];
            }

            if (!sumOccurrences.ContainsKey(sum)) {
                sumOccurrences[sum] = 0;
            }
            sumOccurrences[sum]++;
        }

        return count;
    }
}