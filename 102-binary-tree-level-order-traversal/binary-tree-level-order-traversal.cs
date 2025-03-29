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
    List<IList<int>> result=new();
    public IList<IList<int>> LevelOrder(TreeNode root) {
        

        BFS(root);
        return result;

        
    }
    public void BFS(TreeNode current)
    {
        if(current==null)
        return;
        Queue<(TreeNode,int)> que=new();
        que.Enqueue((current,0));
       
        while(que.Count>0)
        {
            var (node,level)=que.Dequeue();
            if(result.Count==level)
            {
                result.Add(new List<int>());
            }
            result[level].Add(node.val);
            if(node.left!=null)
            que.Enqueue((node.left,level+1));
            if(node.right!=null)
            que.Enqueue((node.right,level+1));
        } 
    }
}