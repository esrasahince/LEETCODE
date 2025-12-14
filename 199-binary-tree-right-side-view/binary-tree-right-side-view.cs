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
    public IList<int> RightSideView(TreeNode root) {
        List<int> result=new();
        if(root==null)
        return result;
        Queue<(TreeNode,int)> que=new();
        que.Enqueue((root,1));

        while(que.Count>0)
        {
            (TreeNode item,int level)=que.Dequeue();
            if(level>result.Count)
            result.Add(item.val);

            if(item.right!=null)
            que.Enqueue((item.right,level+1));
            if(item.left!=null)
            que.Enqueue((item.left,level+1));


        }
        return result;
        
    }
}