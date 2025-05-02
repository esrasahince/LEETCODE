public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
      
        return InOrder(root,p,q);
        
    }
    public TreeNode InOrder(TreeNode current, TreeNode p, TreeNode q)
    {
        if(current==null)
        return null;
        if(current==p||current==q)
        return current;

        TreeNode left=InOrder(current.left,p,q);
        TreeNode right=InOrder(current.right,p,q);
        if(left!=null&&right!=null)
        return current;
        
        return left??right;

     
      
        
    }
}