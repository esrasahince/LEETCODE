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
    public int ClosestValue(TreeNode root, double target) {
        int result=int.MaxValue;
        DFS(root,target,ref result);
        return result;
        
    }
    public void  DFS(TreeNode root, double target, ref int result)
    {
        if(root==null)
        return;
        if(Math.Abs(result-target)==Math.Abs(root.val-target))
        {
            result=result<root.val?result:root.val;
                    }
        if(Math.Abs(result-target)>Math.Abs(root.val-target))
        result=root.val;

        if(target<root.val)
        DFS(root.left,target,ref result);
        else
        DFS(root.right,target,ref result);

    }
}