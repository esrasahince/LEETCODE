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
        
      Recursive(root,ref result);
      return result;


    }
    public void Recursive(TreeNode root, ref int result)
    {
        if(root==null)
        return;
        int left=CalculateHeight(root.left);
        int right=CalculateHeight(root.right);

        result=Math.Max(left+right,result);
        Recursive(root.left,ref result);
        Recursive(root.right,ref result);
        

    }
    public int CalculateHeight(TreeNode node)
    {
        if(node==null)
        return 0;
        return Math.Max(CalculateHeight(node.left),CalculateHeight(node.right))+1;
    }
}