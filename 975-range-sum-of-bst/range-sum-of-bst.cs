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
    public int RangeSumBST(TreeNode root, int low, int high) {
        int sum=0;
         bool check=false;
    
    DFS(root,low,high,ref sum);
    return sum;

        
    }
    public void DFS(TreeNode root,int low,int high, ref int sum)
    {
        if(root==null)
        return;
        DFS(root.left,low,high,ref sum);
        if(root.val>=low&&root.val<=high)
        {
            sum+=root.val;
        }
        if(root.val>high)
        return;
        DFS(root.right,low,high,ref sum);
    }
}