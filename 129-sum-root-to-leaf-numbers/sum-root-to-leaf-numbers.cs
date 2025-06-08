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
    public int SumNumbers(TreeNode root) {
        StringBuilder temp=new();
        int sum=0;
        DFS(root,temp,ref sum);
        return sum;
        
    }
    public void DFS(TreeNode root,StringBuilder temp,ref int sum)
    {
        if(root==null)
        return;
        temp.Append(root.val.ToString());
        if(root.left==null&&root.right==null)
        {
         
            sum+=Convert.ToInt32(temp.ToString());
        }
        else
        {
            DFS(root.left,temp,ref sum);
            DFS(root.right,temp,ref sum);
            
        }
        temp.Remove(temp.Length-1,1);
    }
}