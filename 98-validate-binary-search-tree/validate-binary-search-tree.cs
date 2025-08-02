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
        int? i=null;
        return DFS(root,ref i);
        
        
    }
    public bool DFS(TreeNode current,ref  int? lastvalue)
    {
        if(current==null)
        return true;

        if(!DFS(current.left,ref  lastvalue))
        return false;

        if(lastvalue.HasValue&&current.val<=lastvalue)
        return false;
        lastvalue=current.val;

        if(!DFS(current.right,ref lastvalue))
         return false;
      

       return true;

    }
    
}