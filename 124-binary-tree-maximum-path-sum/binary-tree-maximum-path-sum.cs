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
    public int DFS(TreeNode current,ref int result)
    {
        if(current==null)
        return 0;
        int left=Math.Max(0, DFS(current.left,ref result));
        int right=Math.Max(0, DFS(current.right,ref result));
        int currentsum=left+right+current.val;
        result=Math.Max(result,currentsum);
        return Math.Max(left,right)+current.val;

    }
}