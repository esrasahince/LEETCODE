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

    List<int> result=new();
    public void Flatten(TreeNode root) {
        if(root==null)
        return;
         
        DFS(root);
        TreeNode current=new(root.val);
        
       
        for(int i=1;i<result.Count;i++)
        {
            root.right=new TreeNode(result[i]);
            root.left=null;
            root=root.right;
        }
    
    }

    public void DFS(TreeNode root)
    {
        if(root==null)
        return;
        result.Add(root.val);
        DFS(root.left);
           
        DFS(root.right);
    }

}