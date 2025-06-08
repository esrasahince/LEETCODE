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
    public bool HasPathSum(TreeNode root, int targetSum) {
        return DFS(root,0,targetSum);
        
    }
    public bool DFS(TreeNode root, int sum,int targetsum)
    {
        if(root==null)
        {
            return false;
        }
        sum+=root.val;
        if(root.left==null&&root.right==null)
        {
            return sum==targetsum?true:false;
        }
       return DFS(root.left,sum,targetsum)||DFS(root.right,sum,targetsum);
    }
}