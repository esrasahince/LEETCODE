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
    public int DiameterOfBinaryTree(TreeNode root) {
        int result=0;
       CalculateHeight(root,ref result);
       return result;


    }

    public int CalculateHeight(TreeNode node,ref int result)
    {
        if(node==null)
        return 0;
         int left=CalculateHeight(node.left,ref result);
         int right=CalculateHeight(node.right,ref result);
         
         result=Math.Max(left+right,result);
        
         return Math.Max(left,right)+1;
    }
}