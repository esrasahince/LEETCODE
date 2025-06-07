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
        bool pcheck=false;
        bool qcheck=false;
        TreeNode result=DFS(root,p,q,ref pcheck,ref qcheck);
     
        return pcheck&&qcheck?result:null;

        
    }
    public TreeNode DFS(TreeNode root, TreeNode p, TreeNode q, ref bool pcheck, ref bool qcheck)
    {
        if(root==null)
        return null;
    
       
        TreeNode left=DFS(root.left,p,q,ref pcheck,ref qcheck);
        TreeNode right=DFS(root.right,p,q,ref pcheck,ref qcheck);
        if(root==p)
        {
            pcheck=true;
            return root;
        }
        if(root==q)
        {
            qcheck=true;
            return root;
        }
       
    
         if(left!=null&&right!=null)
        return root;
        
        return left!=null?left:right;
    }
}