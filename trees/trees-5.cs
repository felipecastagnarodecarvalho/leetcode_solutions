// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }

    private TreeNode SortedArrayToBST(int[] nums, int left, int right) {
        if (left > right) return null;
        
        // Choose the middle element to maintain balance.
        int mid = left + (right - left) / 2;
        
        // Create a new tree node from the middle element.
        TreeNode node = new TreeNode(nums[mid]);
        
        // Recursively build the left and right subtrees.
        node.left = SortedArrayToBST(nums, left, mid - 1);
        node.right = SortedArrayToBST(nums, mid + 1, right);
        
        return node;
    }
}


// 1, 2, 3, 4, 5
//    3
//  2 ,  4
//1        5