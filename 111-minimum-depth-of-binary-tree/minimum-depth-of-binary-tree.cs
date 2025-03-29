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
    public int MinDepth(TreeNode root) {
        if(root==null)
        return 0;
        int result=int.MaxValue;
         DFS(root,1,ref result);
         return result;

        
    }
    public void DFS(TreeNode current,int level, ref int result)
    {
        if(current==null)
        return;
        if(current.left==null&&current.right==null)
        result=Math.Min(level,result);
        DFS(current.left,level+1,ref result);
        DFS(current.right,level+1,ref result);
       
    }
}