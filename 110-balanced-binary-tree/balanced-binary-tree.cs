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
    public bool IsBalanced(TreeNode root) {
        bool result = true;
        DFS(root, 0, ref result);
        return result;
    }
    
    private int DFS(TreeNode current, int level, ref bool result) {
        // Base case: null node
        if (current == null)
            return 0;
        
        // Recursively check left subtree
        int left = DFS(current.left, level + 1, ref result);
        
        // If already unbalanced, stop further processing
        if (!result)
            return 0;
        
        // Recursively check right subtree
        int right = DFS(current.right, level + 1, ref result);
        
        // If already unbalanced, stop further processing
        if (!result)
            return 0;
        
        // Check balance condition
        result = Math.Abs(left - right) <= 1;
        
        // Return the maximum height
        return Math.Max(left, right) + 1;
    }

}