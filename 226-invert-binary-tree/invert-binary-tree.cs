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
    public TreeNode InvertTree(TreeNode root) {
        DFS(root);
        return root;

        
    }

    public void DFS(TreeNode node)
    {
        if(node==null)
        return;
        TreeNode temp=node.left;
        node.left=node.right;
        node.right=temp;
        DFS(node.left);
        DFS(node.right);
    }
}