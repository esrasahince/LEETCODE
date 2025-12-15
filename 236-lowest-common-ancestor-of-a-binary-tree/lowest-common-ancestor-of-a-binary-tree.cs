/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {

        return DFS(root,p,q);
        
    }

    public TreeNode DFS(TreeNode node, TreeNode p, TreeNode q)
    {
        if(node==null)
        return null;
        if(node==p||node==q)
        return node; //dont need to traverse the branch

        TreeNode left=DFS(node.left,p,q);
        TreeNode right=DFS(node.right,p,q);
         if(left!=null&&right!=null)
            return node;

        return left==null?right:left;


    }
}