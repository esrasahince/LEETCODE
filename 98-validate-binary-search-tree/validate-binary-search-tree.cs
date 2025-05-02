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
        return InOrder(root,long.MaxValue,long.MinValue);
        
    }

    public bool InOrder(TreeNode current,long max,long min)

    {
        if(current==null)
        return true;
        if(current.val<=min||current.val>=max)
        return false;

        if(!InOrder(current.left,current.val,min))
        return false;
        if(!InOrder(current.right,max,current.val))
        return false;

        return true;



      


    }
}