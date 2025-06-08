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
    public int MaxPathSum(TreeNode root) {
        int result=int.MinValue;
        DFS(root,ref result);
        return result;
        
    }
  
    public int DFS(TreeNode root,ref int result)
    {
        if(root==null)
        return 0;
        int left = Math.Max(0, DFS(root.left, ref result));
        int right = Math.Max(0, DFS(root.right, ref result));
        
        result=Math.Max(result,right+left+root.val);
      

        int current=Math.Max(left,right)+root.val;
    
        return current;

    }
}