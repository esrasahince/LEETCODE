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
    public int MinDepth(TreeNode root) {
        if(root==null)
        return 0;
        return BFS(root);
        
    }
    public int BFS(TreeNode root)
    {
        Queue<(TreeNode,int)> que=new();
        que.Enqueue((root,1));
        while(que.Count>0)
        {
            var (current,level)=que.Dequeue();
            if(current.left==null&&current.right==null)
            return level;

            if(current.left!=null)
            {
                que.Enqueue((current.left,level+1));

            }
            if(current.right!=null)
            {
                que.Enqueue((current.right,level+1));
            }
        }
        return 0;
    }
}