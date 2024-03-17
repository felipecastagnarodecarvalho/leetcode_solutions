// Given two integer arrays nums1 and nums2, return an array of their intersection.
// Each element in the result must appear as many times as it shows in both arrays
// and you may return the result in any order.
public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        // Use a dictionary to keep track of the counts of elements in nums1
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (var num in nums1) {
            if (!counts.ContainsKey(num)) {
                counts[num] = 0;
            }
            counts[num]++;
        }
        
        // Create a list to store the intersection
        List<int> intersection = new List<int>();
        foreach (var num in nums2) {
            if (counts.ContainsKey(num) && counts[num] > 0) {
                intersection.Add(num);
                counts[num]--;
            }
        }
        
        // Convert the list to an array and return
        return intersection.ToArray();
    }
}