// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
// You must write an algorithm that runs in O(n) time and without using the division operation.
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int length = nums.Length;
        int[] leftProducts = new int[length];
        int[] rightProducts = new int[length];
        int[] output = new int[length];

        // Initialize the leftProducts array
        leftProducts[0] = 1;
        for (int i = 1; i < length; i++) {
            leftProducts[i] = nums[i - 1] * leftProducts[i - 1];
        }

        // Initialize the rightProducts array
        rightProducts[length - 1] = 1;
        for (int i = length - 2; i >= 0; i--) {            
            rightProducts[i] = nums[i + 1] * rightProducts[i + 1];
        }

        // Construct the output array
        for (int i = 0; i < length; i++) {
            output[i] = leftProducts[i] * rightProducts[i];
        }

        return output;
    }
}