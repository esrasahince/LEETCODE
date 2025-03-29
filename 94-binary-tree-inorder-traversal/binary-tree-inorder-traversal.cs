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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> result=new();
        Traversal(root, result);
        return result;
     
        
    }
    public void Traversal(TreeNode current, List<int> result)
    {
        if(current==null)
        return;
        Traversal(current.left,result);
        result.Add(current.val);
        Traversal(current.right,result);

    }
}