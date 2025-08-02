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
        return Find(root,p,q);
        
    }

    public TreeNode Find(TreeNode current,TreeNode p, TreeNode q)
    {
        if(current==null)
        return null;
        if(current==p||current==q)
        return current;

        TreeNode left=Find(current.left,p,q);
        TreeNode right=Find(current.right,p,q);
        if(left!=null&right!=null)
          return current;
        return left!=null?left:right;
    }
}