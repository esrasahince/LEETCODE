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
        DFS(root,ref result);
        return result;


        
    }

    public int DFS(TreeNode root, ref bool result)
    {
        if(root==null)
        return 0;

        if(result==false)
        return -1;
        
        int left=DFS(root.left,ref result)+1;
        int right=DFS(root.right,ref result)+1;
        if(left==0||right==0)
        return -1;
        
        if(Math.Abs(left-right)>1)
        result=false;

        return Math.Max(left,right);


    }
}