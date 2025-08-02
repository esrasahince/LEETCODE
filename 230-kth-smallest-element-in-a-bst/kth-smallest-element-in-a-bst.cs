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
    public int KthSmallest(TreeNode root, int k) {
  
        return InOrder(root,ref k);
        
    }
    public int InOrder(TreeNode current,ref int k)
    {
        if(current==null)
        return -1;

        int resultleft=InOrder(current.left,ref k);
        if(resultleft!=-1)
        return resultleft;
        k--;
        if(k==0)
        return current.val;
        int resultright=InOrder(current.right,ref k);
        if(resultright!=-1)
        return resultright;

        return -1;


    }
}