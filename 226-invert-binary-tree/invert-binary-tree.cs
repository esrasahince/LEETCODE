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
    public void DFS(TreeNode root)
    {
        if (root==null)
        return;
        TreeNode left=root.left;
        TreeNode right=root.right;
        root.left=right;
        root.right=left;
        DFS(root.left);
        DFS(root.right);
    }
}