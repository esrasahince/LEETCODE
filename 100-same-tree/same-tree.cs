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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        bool result=true;
        PreOrder(p,q,ref result);
        return result;
        
    }
    public void PreOrder(TreeNode p,TreeNode q,ref bool result)
    {
        if(p==null&&q==null)
        {
            return;
        }
         if(p==null||q==null)
        {   result=false;
            return;
        }
        if(p.val!=q.val)
        {
            result=false;
            return;
        }
        PreOrder(p.left,q.left,ref result);
        PreOrder(p.right,q.right,ref result);
    }
}