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
    public int PathSum(TreeNode root, int targetSum) {
        int result=0;
         Traverse(root,targetSum,ref result);
         return result;
        
    }
    public void Traverse(TreeNode root,int target,ref int count)
    {
        if(root==null)
        return;
        DFS(root,target,0,ref count);
        Traverse(root.left,target,ref count);
        Traverse(root.right,target,ref count);
    }
    public void DFS(TreeNode root, int targetsum,long sum, ref int count)
    {
        if(root==null)
        return;
        sum+=root.val;

        if(targetsum==sum)
        {
            count++;
           
        }
       DFS(root.left,targetsum,sum,ref count);
       DFS(root.right,targetsum,sum,ref count);
  
    }
}