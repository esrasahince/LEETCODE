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
    public bool IsValidBST(TreeNode root) {
        bool result=true;
        Stack<int> stack=new();
        check(root,ref result,stack);
        return result;
    }
    public void check(TreeNode root,ref bool result,Stack<int> stack)
    {
        if(root==null)
          return;

       if(root.left!=null)
        {
            check(root.left,ref result,stack);
        }
        if(stack.Count>0)
        {
        if(stack.Pop()>=root.val)
        result=false;
        }
        stack.Push(root.val);
                                                                           
         if(root.right!=null)
        {
         
            check(root.right,ref result,stack);
        }
        

    
        
    }
}