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
      return CheckBalance(root);
    }
    public bool CheckBalance(TreeNode current)
    {
        if(current==null)
        return true;

        if(Math.Abs(CalculateHeight(current.left)-CalculateHeight(current.right))>1)
        return false;

        return CheckBalance(current.left)&&CheckBalance(current.right);
        

        
        

    }
    public int CalculateHeight(TreeNode current)
    {
        if(current==null)
        return 0;
        
        return Math.Max(CalculateHeight(current.left),CalculateHeight(current.right))+1;
    }
    
    

}