// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        int count = 0;

        for (int start = 0; count < nums.Length; start++) {
            int current = start;
            int prev = nums[start];
            do {
                int next = (current + k) % nums.Length;
                int temp = nums[next];
                nums[next] = prev;
                prev = temp;
                current = next;
                count++;
            } while (start != current);
        }
    }
}