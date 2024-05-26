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
    public bool IsBalanced(TreeNode root) {
        if(root==null)
        return true;
        bool result=true;
        DFSHeight(root,ref result);
        return result;


     
        
    }

    public int DFSHeight(TreeNode root,ref bool result)
    {
        if(root==null)
        return 1;
        int leftheight=DFSHeight(root.left,ref result);
        int rightheight=DFSHeight(root.right,ref result);

        if(Math.Abs(leftheight-rightheight)>1)
        result=false;

        return 1+Math.Max(leftheight,rightheight);


       
       
    }
     
  
}