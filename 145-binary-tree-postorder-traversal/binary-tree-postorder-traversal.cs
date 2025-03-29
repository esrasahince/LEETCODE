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
    
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result=new();
        Traversal(root,result);
        return result;
        
    }
    public void Traversal(TreeNode root,List<int> result)
    {
        if(root==null)
        {
            return;
        }
        Traversal(root.left,result);
        Traversal(root.right,result);
        result.Add(root.val);
    }
}