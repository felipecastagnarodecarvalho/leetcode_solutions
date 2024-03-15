// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var listsOfList = new List<List<int>>();

        if (root == null) {
            return listsOfList.Cast<IList<int>>().ToList();
        }
        
        var level = 0;
        var levelMap = new Dictionary<int, List<int>>();
        
        BuildList(root, levelMap, level);
        
        for(int i = 0; i < levelMap.Count; i++) {
            listsOfList.Add(levelMap[i]);
        }
        
        return listsOfList.Cast<IList<int>>().ToList();
    }
    
    private void BuildList(TreeNode node, Dictionary<int, List<int>> levelMap, int level) {
        if (levelMap.ContainsKey(level)) {
            levelMap[level].Add(node.val);
        } else {
            var list = new List<int>(){node.val};
            levelMap.Add(level, list);
        }
        


        if (node.left != null) {
            BuildList(node.left, levelMap, level + 1);
        }

        if (node.right != null) {
            BuildList(node.right, levelMap, level + 1);
        }
    }
}