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
        if(root==null)
        return root;

        BFS(root);
        return root;
    

        
    }
    public void BFS(TreeNode root)
    {
        Queue<TreeNode> que=new();
        que.Enqueue(root);
        while(que.Count>0)
        {
            TreeNode current=que.Dequeue();
            TreeNode templeft=null;
            TreeNode tempright=null;

            if(current.left!=null)
            {
                templeft=current.left;
                que.Enqueue(current.left);
        
            }
            if(current.right!=null)
            {
                tempright=current.right;
                que.Enqueue(current.right);
            }
             current.right=templeft;
             current.left=tempright;
            
        }
    }
}