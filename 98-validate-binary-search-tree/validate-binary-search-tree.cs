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
        return DFS(root,long.MinValue,long.MaxValue);
        
    }
    public bool DFS(TreeNode node, long lower,long upper)
    {
        if(node==null)
        return true;
        if(node.val>=upper||node.val<=lower)
        return false;

        return DFS(node.left,lower, node.val)&&DFS(node.right,node.val,upper);
    }
}