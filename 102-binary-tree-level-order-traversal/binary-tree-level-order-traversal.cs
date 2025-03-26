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
    public IList<IList<int>> LevelOrder(TreeNode root) {
         List<IList<int>> result=new();
        if(root==null)
        return result;
        if(root.left==null&&root.right==null)
        {
        result.Add(new List<int>{root.val});
         return result;
        }
        DFS(root,result);
        return result;
        
    }

    public void DFS(TreeNode root, List<IList<int>> result)
  
    {
        Queue<(TreeNode,int)> que=new();
        que.Enqueue((root,0));
        

        while(que.Count>0)
        {
            var (current, level) = que.Dequeue(); 
            
            if (result.Count <= level) {
                result.Add(new List<int>());
            }
    
            result[level].Add(current.val);
            level++;


            if(current.left!=null)
            {  
                que.Enqueue((current.left,level));
            }
             if(current.right!=null)
            {  
                que.Enqueue((current.right,level));
            }
            
        }

    }
}