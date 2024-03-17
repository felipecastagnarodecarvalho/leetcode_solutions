// Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
// Note that you must do this in-place without making a copy of the array.
public class Solution {
    public void MoveZeroes(int[] nums) {
        var nonZeroElements = new List<int>();
        var zeroCounter = 0;
        foreach (var num in nums) {
            if (num != 0) {
                nonZeroElements.Add(num);
            } else {
                zeroCounter++;
            }
        }
        
        for (int i = 0; i <= zeroCounter; i++) {
            nonZeroElements.Add(0);
        }
        
        for (int i = 0; i < nums.Length; i++) {
            nums[i] = nonZeroElements[i];
        }        
    }
}