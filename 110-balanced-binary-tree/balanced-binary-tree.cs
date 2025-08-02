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
        bool result=true;
        CalculateHeight(root,ref result);
        return result;

        
    }
    public int CalculateHeight(TreeNode current, ref bool result)
    {
        if(current==null)
         return 0;
        
        int left=CalculateHeight(current.left,ref result);
        int right=CalculateHeight(current.right,ref result);

        if(Math.Abs(left-right)>1)
        result=false;

        return Math.Max(left,right)+1;
    }
}