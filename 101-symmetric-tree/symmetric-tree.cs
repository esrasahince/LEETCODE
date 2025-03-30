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
    public bool IsSymmetric(TreeNode root) {
        if(root==null||(root.left==null&&root.right==null))
        return true;
        return Check(root.left,root.right);
        
    }
    public bool Check(TreeNode p, TreeNode q)
    {
        if(p==null&&q==null)
        return true;
        if(p==null||q==null||p.val!=q.val)
        return false;
        return Check(p.left,q.right)&&Check(p.right,q.left);
       


    }
}