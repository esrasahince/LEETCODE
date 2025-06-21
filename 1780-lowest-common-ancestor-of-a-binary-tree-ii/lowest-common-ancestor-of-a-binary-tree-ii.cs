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
    TreeNode result=LCA(root,p,q);
    if(result!=p&&result!=q)
    return result;

    bool res1=Find(root,p);
    bool res2=Find(root,q);
    return res1&&res2?result:null;    
    
    }
    public TreeNode LCA(TreeNode root, TreeNode p,TreeNode q)
    {
        if(root==null)
        return null;
        if(root==p ||root==q)
        return root;
        TreeNode left= LCA(root.left,p,q);
        TreeNode right=LCA(root.right,p,q);
        if(left!=null&&right!=null)
        return root;
        
        return left!=null?left:right;
    }
    public bool Find(TreeNode root,TreeNode x)
    {
        if(root==null)
        return false;
        if(root==x)
        return true;

        return Find(root.left,x)||Find(root.right,x);
    }
}