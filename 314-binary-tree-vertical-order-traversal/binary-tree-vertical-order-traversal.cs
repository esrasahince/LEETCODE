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
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        List<IList<int>> result=new();
        SortedList<int,List<int>> dict=new();
        if(root==null)
        return result;

        Queue<(TreeNode,int)> que=new();
        que.Enqueue((root,0));
        
        while(que.Count>0)
        {
            (TreeNode node,int level)=que.Dequeue();
            if(!dict.ContainsKey(level))
            {
                dict[level]=new List<int>();

            }
            dict[level].Add(node.val);
       
            if(node.left!=null)
            que.Enqueue((node.left,level-1));
            if(node.right!=null)
            que.Enqueue((node.right,level+1));
        }
        int length=dict.Count;
        foreach(var item in dict)
        {
            result.Add(item.Value);

        }

          return result;



        
    }

}