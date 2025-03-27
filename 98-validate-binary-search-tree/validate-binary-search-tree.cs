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
       int? min=null;

        return InOrderTraversal(root,ref min);

        
    }
    public bool InOrderTraversal(TreeNode current,ref int? last)
    {
        if(current==null)
        return true;

        if(!InOrderTraversal(current.left,ref last))
        return false;

        if(last.HasValue&&current.val<=last)
        {
         
          return false;
        }
        last=current.val;
        
        if(!InOrderTraversal(current.right,ref last))
        return false;

       return true;


    }
}