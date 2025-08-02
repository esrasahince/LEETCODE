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
    public int WidthOfBinaryTree(TreeNode root) {

        if(root==null)
        return 0;
        int result=0;
        Queue<(TreeNode,int,int)> que=new();
        que.Enqueue((root,0,0));
        int lastlevel=0;
        int start=0;
        int lastindex=0;
        while(que.Count>0)
        {
            (TreeNode current,int level,int index)=que.Dequeue();
            if(level!=lastlevel)
            
            {  
                result=Math.Max(result,lastindex-start+1);
                
                 start=index;
                lastlevel=level;
                
            }

          
            if(current.left!=null)
            que.Enqueue((current.left,level+1,2*index+1));
            if(current.right!=null)
            que.Enqueue((current.right,level+1,2*index+2));
            lastindex=index;
        }
        result=Math.Max(result,lastindex-start+1);
        return result;
        
    }
}