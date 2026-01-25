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
    public int DiameterOfBinaryTree(TreeNode root) {
        int result=0;

         DFS(root,ref result);
        return result;
        
    }
    public int DFS(TreeNode root, ref int max)
    {
        if(root==null)
        return 0;
        int left=DFS(root.left,ref max);
        int right=DFS(root.right,ref max);
        max=Math.Max(left+right,max);
        return Math.Max(left,right)+1;
    }
}