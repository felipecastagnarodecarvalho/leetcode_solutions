// Given an integer array nums, design an algorithm to randomly shuffle the array. All permutations of the array should be equally likely as a result of the shuffling.
// Implement the Solution class:
//     Solution(int[] nums) Initializes the object with the integer array nums.
//     int[] reset() Resets the array to its original configuration and returns it.
//     int[] shuffle() Returns a random shuffling of the array.
public class Solution {
    private int[] nums;

    public Solution(int[] nums) {
        this.nums = nums;
    }
    
    public int[] Reset() {
        return nums;
    }
    
    public int[] Shuffle() {
        int[] shuffleNums = new int[nums.Length];
        var indexAddedList = new List<int>();
        
        for (int i = 0; i < nums.Length; i++) {
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, nums.Length);
            while (indexAddedList.Contains(randomIndex)) {
                randomIndex = rnd.Next(0, nums.Length);
            }
                
            shuffleNums[i] = nums[randomIndex];
            indexAddedList.Add(randomIndex);
        }
        
        return shuffleNums;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */