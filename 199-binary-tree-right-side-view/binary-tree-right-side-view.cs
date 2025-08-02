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
        Dictionary<int,int> dict=new();
        Queue<(TreeNode,int)> que=new();
        que.Enqueue((root,0));

        while(que.Count>0)
        {
            (TreeNode current,int level)=que.Dequeue();
          
            dict[level]=current.val;
            
            if(current.left!=null)
            que.Enqueue((current.left,level+1));
            if(current.right!=null)
            que.Enqueue((current.right,level+1));
        }

        int count=0;
        while(count<dict.Count)
        {
            result.Add(dict[count]);
            count++;

        }
        return result;

        
    }
}