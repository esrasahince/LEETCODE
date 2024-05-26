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
     var result=DFSHeight(root);
     Console.WriteLine(result);
     if(result!=-1)
     return true;
     else return false;
        
    }

    public int DFSHeight(TreeNode root)
    {
        if(root==null)
        return 1;
        int leftheight=DFSHeight(root.left);
        int rightheight=DFSHeight(root.right);

        if(leftheight==-1||rightheight==-1)
        return -1;


        if(Math.Abs(leftheight-rightheight)>1)
        return -1;

        return 1+Math.Max(DFSHeight(root.left),DFSHeight(root.right));
        
       
    }
     
  
}