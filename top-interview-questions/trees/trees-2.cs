// Given the root of a binary tree, determine if it is a valid binary search tree (BST).
// A valid BST is defined as follows:
//     The left subtree of a node contains only nodes with keys less than the node's key.
//     The right subtree of a node contains only nodes with keys greater than the node's key.
//     Both the left and right subtrees must also be binary search trees.
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
       public bool IsValidBST(TreeNode root) {
        return IsValidBST(root, null, null);
    }
    
    private bool IsValidBST(TreeNode node, int? lower, int? upper) {
        if (node == null) return true;

        if (lower.HasValue && node.val <= lower.Value) return false;
        if (upper.HasValue && node.val >= upper.Value) return false;

        if (!IsValidBST(node.right, node.val, upper)) return false;
        if (!IsValidBST(node.left, lower, node.val)) return false;

        return true;
    }
}