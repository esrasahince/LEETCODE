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
        if(root==null)
        return false;
        return DFS(root,0,targetSum);
        
    }

    public bool DFS(TreeNode current, int currentval,int target)
    {
        if(current==null)
        return false;
        if(current.left==null&&current.right==null&&target==currentval+current.val)
        return true;
        return DFS(current.left,current.val+currentval,target)||DFS(current.right,current.val+currentval,target);
    }
}