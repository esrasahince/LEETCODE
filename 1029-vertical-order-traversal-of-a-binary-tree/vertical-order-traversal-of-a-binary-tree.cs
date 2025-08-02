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
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        List<IList<int>> result=new();
        if(root==null)
        return result;

        SortedDictionary<int,List<List<int>>> dict=new();
        Queue<(TreeNode,int,int)> que=new();
        que.Enqueue((root,0,0));
        while(que.Count>0)
        {
            (TreeNode current,int level,int index)=que.Dequeue();
            if(!dict.ContainsKey(index))
            {
                dict[index]=new List<List<int>>();
            }
                dict[index].Add(new List<int>(){level,current.val});

        
            if(current.left!=null)
            que.Enqueue((current.left,level+1,index-1));
            if(current.right!=null)
            que.Enqueue((current.right,level+1,index+1));
        }
        foreach(var item in dict)
        {
            var list=item.Value;
            list.Sort((a,b)=> {
                int first=a[0].CompareTo(b[0]);
              if(first!=0) return first;
            return a[1].CompareTo(b[1]);
            });

            List<int> temp=new();
            foreach(var i in list)
            {
                temp.Add(i[1]);
            }
            result.Add(temp);
        }
        return result;
        
    }
}