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

        Queue<(TreeNode,int)> queue=new();
        queue.Enqueue((root,0));
      
        int maxlevel=0;
      
     
        while(queue.Count>0)
        {
            var item=queue.Dequeue();
            TreeNode node=item.Item1;
            int level=item.Item2;

            maxlevel=Math.Max(level,maxlevel);
            if(result.Count<=maxlevel)
            {
                result.Add(new List<int>());
            }
            result[level].Add(node.val);
            if(node.left!=null)
            {
                queue.Enqueue((node.left,level+1));
             
            }
              if(node.right!=null)
            {
                queue.Enqueue((node.right,level+1));
                
            }
          
        }
   
        return result;
        
    }
}